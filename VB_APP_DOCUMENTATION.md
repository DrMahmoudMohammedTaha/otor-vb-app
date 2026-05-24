# OTOR VB.NET Desktop App Documentation

Welcome to the **OTOR VB.NET Desktop App** developer documentation. This application is a Windows Forms desktop client written in Visual Basic (VB.NET) running on **.NET 8.0-windows**. It acts as the primary administrative dashboard and desktop portal for managing the **OTOR AlQuran Quranic Ejaza Portal**.

This document is structured to help developers, particularly junior engineers, understand the architecture, UI controls, API service layer, and how to compile and run the desktop application.

---

## 1. Project Overview

The OTOR Desktop App is a WinForms GUI designed to run locally on Windows machines. It enables the system administrator (and sheikhs using desktop endpoints) to:
1. Manage student records, verify Ejaza certificate lines, and log details.
2. Edit active certificate print orders, update workflow states (NEXT $\rightarrow$ DESIGN $\rightarrow$ PRINT $\rightarrow$ POST $\rightarrow$ DELIVER), and archive completed items.
3. Review company expenses, categorize costs, and track package postage intervals.
4. Preview gallery certificate design sheets, backgrounds, and signature frames.

All CRUD operations are bound asynchronously to the FastAPI backend portal via the `ApiClient` wrapper class.

---

## 2. Tech Stack & Dependencies

The project relies on standard .NET 8 libraries built into the Windows workload:

1. **.NET 8.0-Windows SDK**: The modern runtime environment for Windows desktop apps, providing superior performance and cross-platform compilation options.
2. **Windows Forms Framework (WinForms)**: The classic event-driven UI framework for building Windows desktop apps.
3. **System.Net.Http (HttpClient)**: Provides a single, reusable thread-safe HTTP client to make asynchronous REST calls to the FastAPI backend.
4. **System.Text.Json**: A high-performance, low-allocating JSON serialization library used to serialize payloads and deserialize API response bodies.
5. **Dynamic Local Assets**: Circular PNG contact icons (`facebook.png`, `whatsapp.png`) copied dynamically to the compilation target directory (`bin/Debug/net8.0-windows`) using project update tags.

---

## 3. Project Directory Structure

Here is a visual map of the `otor-vb-app` workspace directory:

```
g:\sanad\sources\otor-vb-app\
│
├── P_OtorVB.vbproj          # MSBuild project file (target framework, imports, assets copy rules)
├── P_OtorVB.vbproj.user     # User-specific visual designer configurations
├── Program.vb               # Bootstraps the application thread and sets startup form
├── ApiClient.vb             # Asynchronous HttpClient client-side controller
├── Models.vb                # Domain entities matching PostgreSQL SQLModel definitions
├── facebook.png             # Facebook contact asset
├── whatsapp.png             # WhatsApp contact asset
├── events.txt               # Debug log records
│
├── FormLogin.vb             # Login screen supporting Admin, Sheikh, and Gallery entries
├── FormLogin.Designer.vb    # Auto-generated UI structure for the Login form
│
├── FormMain.vb              # Main Admin shell hosting modular user controls
├── FormMain.Designer.vb     # Auto-generated UI structure for the Main form
│
├── FormGallery.vb           # Catalog browser displaying design sheets
├── FormGallery.Designer.vb  # Auto-generated UI structure for the Gallery form
│
├── FormSheikhDashboard.vb   # Tabbed stats and orders browser for Sheikh portals
├── FormSheikhDashboard.Designer.vb # Auto-generated UI structure for the Sheikh Dashboard
│
├── FormContentEdit.vb       # Form to add or update individual student certificates
├── FormOrderContent.vb      # List layout showing all student names in a selected order
├── FormOrderEdit.vb         # Editor to add or adjust order price, receiver, or degree priority
├── FormSheikhEdit.vb        # Registry editor for teacher profiles
│
├── UcSheikhs.vb             # Modular User Control managing sheikh directory tables
├── UcOrders.vb              # Modular User Control displaying active orders and states
└── UcExpenses.vb            # Modular User Control logging transactions and categories
```

---

## 4. Setup & Installation

### Prerequisites
- Windows OS (required for WinForms execution).
- .NET 8.0 SDK installed.
- The running FastAPI backend service (e.g. locally on port 8000 or hosted remotely).

### Step 1: Configure base backend URL
Open [ApiClient.vb](file:///g:/sanad/sources/otor-vb-app/ApiClient.vb) and locate the `BaseUrl` property on line 9:
```vb
Public Shared Property BaseUrl As String = "https://mahmoud-taha-otor-portal.hf.space"
```
Change this value if you are pointing to a local dev server (e.g., `"http://127.0.0.1:8000"`).

### Step 2: Compile the Project
Open a PowerShell command prompt in the project root directory and run:
```powershell
dotnet build
```
This restores packages, verifies imports, and copies the `facebook.png` and `whatsapp.png` files to the output folder.

### Step 3: Run the Application
Start the desktop application from the console:
```powershell
dotnet run
```

---

## 5. Core Modules & Architecture Breakdown

### A. The Client API Router (`ApiClient.vb`)
This is the service layer wrapper for the app. It declares a single static instance of `HttpClient` to prevent socket exhaustion.
Key highlights:
- **Authorization Headers**: When logging in, `LoginAsync` retrieves a session token and passes it to `SetAuthToken()`. This attaches the bearer authorization header to all subsequent API calls:
  ```vb
  client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Bearer", Token)
  ```
- **Asynchronous Wrappers**: Every function returns a `Task(Of T)` (e.g. `Task(Of List(Of Sheikh))`), allowing Windows Forms to remain interactive and responsive during network operations (avoiding UI freezing).
- **JSON Serialization Options**: Case-insensitivity is enabled to map python snake_case fields (e.g. `sheikh_id`) directly to Visual Basic properties:
  ```vb
  Private Shared ReadOnly jsonOptions As New JsonSerializerOptions With {
      .PropertyNameCaseInsensitive = True,
      .DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
  }
  ```

### B. User Control Host Architecture (`FormMain.vb`)
The Main Administrator portal (`FormMain`) behaves like a Single-Page Application (SPA) using **User Controls** (`UserControl`):
- Instead of spawning separate windows for Sheikhs, Orders, and Expenses, three controls are instantiated: `UcSheikhs`, `UcOrders`, and `UcExpenses`.
- When an admin clicks a sidebar navigation button (e.g., "الطلبات"), `FormMain` clears its main panel client canvas and fills it with the target control:
  ```vb
  pnlContainer.Controls.Clear()
  Dim uc = New UcOrders()
  uc.Dock = DockStyle.Fill
  pnlContainer.Controls.Add(uc)
  ```
- This keeps the visual flow clean, unified, and high-performance.

---

## 6. Detailed Form Configurations

### A. Login Form (`FormLogin`)
- **Visual Design**: The form contains a right-docked banner image and a left-docked control panel containing login credentials.
- **Entry Modes**: A dropdown menu (`cmbRole`) switches visibility between panels:
  - *Admin Mode*: Requires entering the master server password.
  - *Sheikh Mode*: Requires entering the registered mobile phone number.
  - *Gallery Mode*: Standard entrance without credentials.
- **Social links**: Positioned at the bottom are the WhatsApp and Facebook icons with hand cursors. Clicking them triggers:
  ```vb
  Dim sInfo As New ProcessStartInfo("https://wa.me/201015192541") With {.UseShellExecute = True}
  Process.Start(sInfo)
  ```

### B. Catalog Browser (`FormGallery`)
- **Categories Sidebar**: Displays buttons representing design folders (`1_ejaza`, `2_background`, etc.).
- **Dynamic Grid Layout**: Clicking a button clears the center `FlowLayoutPanel` and executes a background folder search. For each image found, it instantiates a `PictureBox` dynamically, sets padding, attaches a hover hand cursor, and displays the image thumbnail.
- **Interactive Fullscreen Zoom**: Clicking a thumbnail instantiates a borderless form (`FormBorderStyle = None`) maximized to fill the screen on top of all windows with the selected image inside it using `Zoom` mode. Pressing `ESC` or clicking anywhere closes the viewer cleanly.

### C. Sheikh Dashboard (`FormSheikhDashboard`)
- **Tab Layouts**:
  - *Active Tab*: A `DataGridView` displaying the logged-in Sheikh's outstanding orders, listing delivery state and remaining balances.
  - *History Tab*: A `DataGridView` displaying archived orders that have been successfully delivered and paid.
- **Header Panels**: Positioned at the top are statistics summaries showing total historical costs, completed certifications count, and active requests. It also embeds the WhatsApp and Facebook shortcut icons next to the logout button.
