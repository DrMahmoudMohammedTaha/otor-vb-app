Imports System.Text.Json.Serialization

Namespace Models

    Public Class Sheikh
        Public Property id As Integer?
        Public Property name As String = ""
        Public Property info As String = ""
        Public Property comment As String = ""
        Public Property gender As Boolean = True ' True = معلم, False = معلمة
        Public Property receiver_name As String = ""
        Public Property phone As String = ""
        Public Property country As String = ""
        Public Property city As String = ""
        Public Property address As String = ""
        Public Property insert_date As DateTime?
    End Class

    Public Class Order
        Public Property id As Integer?
        Public Property state As String = "NEXT"
        Public Property sheikh_id As Integer?
        Public Property sheikh_name As String = ""
        Public Property comment As String = ""
        Public Property contents As String = ""
        Public Property cost As Double = 0.0
        Public Property paid As Double = 0.0
        Public Property rest As Double = 0.0
        Public Property p_receiver As String = ""
        Public Property p_phone As String = ""
        Public Property p_country As String = ""
        Public Property p_city As String = ""
        Public Property p_address As String = ""
        Public Property insert_date As DateTime?
        Public Property update_date As DateTime?
        Public Property degree As Double = 0.0

        ' Fields added by API helper response
        Public Property sheikh_phone As String = ""
        Public Property sheikh_city As String = ""
    End Class

    Public Class OrderDetailsResponse
        Public Property archived As Boolean
        Public Property order As Order
        Public Property sheikh As Sheikh
    End Class

    Public Class ContentItem
        Public Property id As Integer?
        Public Property order_id As Integer?
        Public Property type As String = "EJAZA"
        Public Property amount As Double = 1.0
        Public Property cost As Double = 0.0
        Public Property comment As String = ""
        Public Property student_name As String = ""
        Public Property student_gender As String = ""
        Public Property student_info As String = ""
        Public Property qeraa As String = ""
        Public Property tareq As String = ""
        Public Property state As String = ""
        Public Property degree As Double = 0.0
        Public Property review As String = ""
    End Class

    Public Class Expense
        Public Property id As Integer?
        Public Property expense As String = ""
        Public Property amount As Double = 0.0
        Public Property category As String = ""
        Public Property comment As String = ""
        Public Property due_date As DateTime?
    End Class

    Public Class ExpenseCategory
        Public Property category As String = ""
        Public Property total As Double = 0.0
    End Class

    Public Class PackageStatus
        Public Property days_elapsed As Integer
        Public Property last_date As DateTime?
    End Class

    Public Class SheikhStats
        Public Property sheikh_id As Integer
        Public Property name As String = ""
        Public Property total_historical_cost As Double
        Public Property total_historical_items As Integer
        Public Property active_orders_count As Integer
    End Class

    Public Class LoginResponse
        Public Property token As String = ""
        Public Property role As String = ""
        Public Property name As String = ""
        Public Property sheikh_id As Integer?
    End Class

End Namespace
