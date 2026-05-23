Imports System.Net.Http
Imports System.Text
Imports System.Text.Json
Imports System.Text.Json.Serialization
Imports P_OtorVB.Models

Public Class ApiClient
    Private Shared ReadOnly client As HttpClient = New HttpClient()
    Public Shared Property BaseUrl As String = "https://mahmoud-taha-otor-portal.hf.space"
    Public Shared Property Token As String = ""

    Public Shared Sub SetAuthToken(authToken As String)
        Token = authToken
        If String.IsNullOrEmpty(Token) Then
            client.DefaultRequestHeaders.Authorization = Nothing
        Else
            client.DefaultRequestHeaders.Authorization = New System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token)
        End If
    End Sub

    Private Shared ReadOnly jsonOptions As New JsonSerializerOptions With {
        .PropertyNameCaseInsensitive = True,
        .DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    }

    Private Shared _initialized As Boolean = False

    ' Setup configuration if needed
    Public Shared Sub Initialize()
        If _initialized Then Return
        _initialized = True
        client.Timeout = TimeSpan.FromSeconds(15)
    End Sub

    ' Helper to build absolute URL
    Private Shared Function GetUrl(path As String) As String
        Return $"{BaseUrl.TrimEnd("/"c)}/{path.TrimStart("/"c)}"
    End Function

    ' ==========================================
    ' SHEIKHS
    ' ==========================================
    Public Shared Async Function GetSheikhsAsync(Optional search As String = Nothing) As Task(Of List(Of Sheikh))
        Dim path As String = "api/sheikhs"
        If Not String.IsNullOrEmpty(search) Then
            path &= $"?search={Uri.EscapeDataString(search)}"
        End If

        Dim response = Await client.GetAsync(GetUrl(path))
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of List(Of Sheikh))(json, jsonOptions)
    End Function

    Public Shared Async Function GetSheikhAsync(id As Integer) As Task(Of Sheikh)
        Dim response = Await client.GetAsync(GetUrl($"api/sheikhs/{id}"))
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of Sheikh)(json, jsonOptions)
    End Function

    Public Shared Async Function GetSheikhStatsAsync(id As Integer) As Task(Of SheikhStats)
        Dim response = Await client.GetAsync(GetUrl($"api/sheikhs/{id}/stats"))
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of SheikhStats)(json, jsonOptions)
    End Function

    Public Shared Async Function CreateSheikhAsync(sheikh As Sheikh) As Task(Of Sheikh)
        Dim jsonContent = JsonSerializer.Serialize(sheikh, jsonOptions)
        Dim content = New StringContent(jsonContent, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync(GetUrl("api/sheikhs"), content)
        response.EnsureSuccessStatusCode()
        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of Sheikh)(responseJson, jsonOptions)
    End Function

    Public Shared Async Function UpdateSheikhAsync(id As Integer, sheikh As Sheikh) As Task(Of Sheikh)
        Dim jsonContent = JsonSerializer.Serialize(sheikh, jsonOptions)
        Dim content = New StringContent(jsonContent, Encoding.UTF8, "application/json")
        Dim response = Await client.PutAsync(GetUrl($"api/sheikhs/{id}"), content)
        response.EnsureSuccessStatusCode()
        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of Sheikh)(responseJson, jsonOptions)
    End Function

    Public Shared Async Function DeleteSheikhAsync(id As Integer) As Task(Of Boolean)
        Dim response = Await client.DeleteAsync(GetUrl($"api/sheikhs/{id}"))
        Return response.IsSuccessStatusCode
    End Function

    ' ==========================================
    ' ORDERS
    ' ==========================================
    Public Shared Async Function GetOrdersAsync(Optional state As String = "ALL", Optional sheikhId As Integer? = Nothing) As Task(Of List(Of Order))
        Dim path = $"api/orders?state={state}"
        If sheikhId.HasValue Then
            path &= $"&sheikh_id={sheikhId.Value}"
        End If
        Dim response = Await client.GetAsync(GetUrl(path))
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of List(Of Order))(json, jsonOptions)
    End Function

    Public Shared Async Function GetOrderHistoryAsync(Optional sheikhId As Integer? = Nothing) As Task(Of List(Of Order))
        Dim path = "api/orders/history"
        If sheikhId.HasValue Then
            path &= $"?sheikh_id={sheikhId.Value}"
        End If
        Dim response = Await client.GetAsync(GetUrl(path))
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of List(Of Order))(json, jsonOptions)
    End Function

    Public Shared Async Function GetOrderDetailsAsync(id As Integer) As Task(Of OrderDetailsResponse)
        Dim response = Await client.GetAsync(GetUrl($"api/orders/{id}"))
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of OrderDetailsResponse)(json, jsonOptions)
    End Function

    Public Shared Async Function CreateOrderAsync(order As Order) As Task(Of Order)
        Dim jsonContent = JsonSerializer.Serialize(order, jsonOptions)
        Dim content = New StringContent(jsonContent, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync(GetUrl("api/orders"), content)
        response.EnsureSuccessStatusCode()
        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of Order)(responseJson, jsonOptions)
    End Function

    Public Shared Async Function UpdateOrderAsync(id As Integer, order As Order) As Task(Of Order)
        Dim jsonContent = JsonSerializer.Serialize(order, jsonOptions)
        Dim content = New StringContent(jsonContent, Encoding.UTF8, "application/json")
        Dim response = Await client.PutAsync(GetUrl($"api/orders/{id}"), content)
        response.EnsureSuccessStatusCode()
        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of Order)(responseJson, jsonOptions)
    End Function

    Public Shared Async Function UpdateOrderStateAsync(id As Integer, state As String) As Task(Of JsonElement)
        Dim payload = New With {Key .state = state}
        Dim jsonContent = JsonSerializer.Serialize(payload, jsonOptions)
        Dim content = New StringContent(jsonContent, Encoding.UTF8, "application/json")
        Dim response = Await client.PutAsync(GetUrl($"api/orders/{id}/state"), content)
        response.EnsureSuccessStatusCode()
        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of JsonElement)(responseJson, jsonOptions)
    End Function

    Public Shared Async Function DeleteOrderAsync(id As Integer) As Task(Of Boolean)
        Dim response = Await client.DeleteAsync(GetUrl($"api/orders/{id}"))
        Return response.IsSuccessStatusCode
    End Function

    ' ==========================================
    ' CONTENT ITEMS (ORDER ITEMS)
    ' ==========================================
    Public Shared Async Function GetContentsAsync(orderId As Integer) As Task(Of List(Of ContentItem))
        Dim response = Await client.GetAsync(GetUrl($"api/content?order_id={orderId}"))
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of List(Of ContentItem))(json, jsonOptions)
    End Function

    Public Shared Async Function CreateContentAsync(item As ContentItem) As Task(Of ContentItem)
        Dim jsonContent = JsonSerializer.Serialize(item, jsonOptions)
        Dim content = New StringContent(jsonContent, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync(GetUrl("api/content"), content)
        response.EnsureSuccessStatusCode()
        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of ContentItem)(responseJson, jsonOptions)
    End Function

    Public Shared Async Function UpdateContentAsync(id As Integer, item As ContentItem) As Task(Of ContentItem)
        Dim jsonContent = JsonSerializer.Serialize(item, jsonOptions)
        Dim content = New StringContent(jsonContent, Encoding.UTF8, "application/json")
        Dim response = Await client.PutAsync(GetUrl($"api/content/{id}"), content)
        response.EnsureSuccessStatusCode()
        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of ContentItem)(responseJson, jsonOptions)
    End Function

    Public Shared Async Function DeleteContentAsync(id As Integer) As Task(Of Boolean)
        Dim response = Await client.DeleteAsync(GetUrl($"api/content/{id}"))
        Return response.IsSuccessStatusCode
    End Function

    Public Shared Async Function BulkInsertContentAsync(orderId As Integer, rawText As String) As Task(Of Integer)
        Dim payload = New With {
            Key .order_id = orderId,
            Key .raw_text = rawText
        }
        Dim jsonContent = JsonSerializer.Serialize(payload, jsonOptions)
        Dim content = New StringContent(jsonContent, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync(GetUrl("api/content/bulk"), content)
        response.EnsureSuccessStatusCode()
        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Dim doc = JsonDocument.Parse(responseJson)
        Return doc.RootElement.GetProperty("inserted_count").GetInt32()
    End Function

    ' ==========================================
    ' EXPENSES
    ' ==========================================
    Public Shared Async Function GetExpensesAsync(Optional category As String = Nothing) As Task(Of List(Of Expense))
        Dim path = "api/expenses"
        If Not String.IsNullOrEmpty(category) Then
            path &= $"?category={Uri.EscapeDataString(category)}"
        End If
        Dim response = Await client.GetAsync(GetUrl(path))
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of List(Of Expense))(json, jsonOptions)
    End Function

    Public Shared Async Function GetExpenseCategoriesAsync() As Task(Of List(Of ExpenseCategory))
        Dim response = Await client.GetAsync(GetUrl("api/expenses/categories"))
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of List(Of ExpenseCategory))(json, jsonOptions)
    End Function

    Public Shared Async Function CreateExpenseAsync(expense As Expense) As Task(Of Expense)
        Dim jsonContent = JsonSerializer.Serialize(expense, jsonOptions)
        Dim content = New StringContent(jsonContent, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync(GetUrl("api/expenses"), content)
        response.EnsureSuccessStatusCode()
        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of Expense)(responseJson, jsonOptions)
    End Function

    ' ==========================================
    ' PACKAGE
    ' ==========================================
    Public Shared Async Function GetPackageStatusAsync() As Task(Of PackageStatus)
        Dim response = Await client.GetAsync(GetUrl("api/package/status"))
        response.EnsureSuccessStatusCode()
        Dim json = Await response.Content.ReadAsStringAsync()
        Return JsonSerializer.Deserialize(Of PackageStatus)(json, jsonOptions)
    End Function

    Public Shared Async Function StartNewPackageAsync() As Task(Of Boolean)
        Dim response = Await client.PostAsync(GetUrl("api/package/start"), Nothing)
        Return response.IsSuccessStatusCode
    End Function

    ' ==========================================
    ' SYSTEM ACTIONS
    ' ==========================================
    Public Shared Async Function OpenSheikhFolderAsync(sheikhName As String) As Task(Of Boolean)
        Dim payload = New With {Key .sheikh_name = sheikhName}
        Dim jsonContent = JsonSerializer.Serialize(payload, jsonOptions)
        Dim content = New StringContent(jsonContent, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync(GetUrl("api/system/open-folder"), content)
        Return response.IsSuccessStatusCode
    End Function

    ' ==========================================
    ' AUTHENTICATION
    ' ==========================================
    Public Shared Async Function LoginAsync(role As String, Optional password As String = Nothing, Optional phone As String = Nothing) As Task(Of LoginResponse)
        Dim payload = New With {
            Key .role = role,
            Key .password = password,
            Key .phone = phone
        }
        Dim jsonContent = JsonSerializer.Serialize(payload, jsonOptions)
        Dim content = New StringContent(jsonContent, Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync(GetUrl("api/auth/login"), content)
        
        If Not response.IsSuccessStatusCode Then
            Dim errJson = Await response.Content.ReadAsStringAsync()
            Try
                Dim doc = JsonDocument.Parse(errJson)
                Dim detail = doc.RootElement.GetProperty("detail").GetString()
                Throw New Exception(detail)
            Catch
                Throw New Exception("فشل تسجيل الدخول. يرجى التحقق من البيانات المدخلة.")
            End Try
        End If
        
        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Dim res = JsonSerializer.Deserialize(Of LoginResponse)(responseJson, jsonOptions)
        
        ' Set authentication token globally for all subsequent calls
        SetAuthToken(res.token)
        
        Return res
    End Function

End Class
