Imports System.Net
Imports System.Text
Imports Newtonsoft.Json.Linq

Module Module1
    Public StrSetLoc As String
    Public IntSetIntv As Integer

    Public Iploc As String
    Public StrMsg As String
    Public StrMsgTitle As String

    Public StrSetAddr As String
    Public BlnAutoIpLoc, BlnIpSer As Boolean

    Public Todweather, Tomweather, Nowtemp, Todtemp, Tomtemp, Toddaypic, Tomdaypic, Todevepic, Tomevepic As String

    Public _
        StrCloDs, StrClo, StrCarDs, StrCar, StrSicDs, StrSic, StrSpoDs, StrSpo As String

    Public IntPm As Integer
    Public StrWind As String

    Dim _joLoc, _joWeather As JObject
    Private _intErrCodeIp As Integer
    Private _intErrCodeWeather As Integer
    Private _intErrCode As Integer
    Private _strErrMsg As String

    Public Sub IpLocation()
        Dim strLocNet As String
        
        Using webcIPloc As New WebClient
            webcIPloc.Encoding = Encoding.Default
            strLocNet = webcIPloc.DownloadString("http://api.map.baidu.com/location/ip?ak=edUWu66ddGavrmj9a6vcsa75")
        End Using

        _joLoc = JObject.Parse(strLocNet)

        _intErrCodeIp = Int(_joLoc.SelectToken("status").ToString)
        If _intErrCodeIp = 0 Then
            Iploc = Split(_joLoc.SelectToken("content.address_detail.city").ToString, "市")(0)
        Else
            _intErrCode = _intErrCodeIp
            ErrorCheck()
            StrMsgTitle = "IP定位失败"
            StrMsg = "Miku无法获取您的位置，错误信息：error code = " + Str(_intErrCode) + " /" + _strErrMsg
            FrmMsg.Show()
        End If
    End Sub

    Public Sub GetWeatherData()
        Dim strWeatherNet As String
        Using weatherWebc As New WebClient
            weatherWebc.Encoding = Encoding.UTF8
            strWeatherNet =
                weatherWebc.DownloadString(
                    "http://api.map.baidu.com/telematics/v3/weather?location=" + StrSetLoc +
                    "&output=json&ak=edUWu66ddGavrmj9a6vcsa75")
        End Using

        _joWeather = JObject.Parse(strWeatherNet)

        _intErrCodeWeather = _joWeather.SelectToken("error").ToString
        If _intErrCodeWeather = 0 Then
            IntPm = Int(_joWeather.SelectToken("results[0].pm25").ToString)
            StrWind = _joWeather.SelectToken("results[0].weather_data[0].wind").ToString
            Nowtemp = Split(Split(_joWeather.SelectToken("results[0].weather_data[0].date").ToString, "：")(1), "℃")(0) + " ℃"
            Toddaypic = _joWeather.SelectToken("results[0].weather_data[0].dayPictureUrl").ToString
            Todevepic = _joWeather.SelectToken("results[0].weather_data[0].nightPictureUrl").ToString
            Todweather = _joWeather.SelectToken("results[0].weather_data[0].weather").ToString
            Todtemp = _joWeather.SelectToken("results[0].weather_data[0].temperature").ToString
            Tomdaypic = _joWeather.SelectToken("results[0].weather_data[1].dayPictureUrl").ToString
            Tomevepic = _joWeather.SelectToken("results[0].weather_data[1].nightPictureUrl").ToString
            Tomweather = _joWeather.SelectToken("results[0].weather_data[1].weather").ToString
            Tomtemp = _joWeather.SelectToken("results[0].weather_data[1].temperature").ToString
            StrCloDs = _joWeather.SelectToken("results[0].index[0].zs").ToString
            StrClo = _joWeather.SelectToken("results[0].index[0].des").ToString
            StrCarDs = _joWeather.SelectToken("results[0].index[1].zs").ToString
            StrCar = _joWeather.SelectToken("results[0].index[1].des").ToString
            StrSicDs = _joWeather.SelectToken("results[0].index[2].zs").ToString
            StrSic = _joWeather.SelectToken("results[0].index[2].des").ToString
            StrSpoDs = _joWeather.SelectToken("results[0].index[3].zs").ToString
            StrSpo = _joWeather.SelectToken("results[0].index[3].des").ToString
            Todtemp = Split(Split(Todtemp, " ~ ")(1), "℃")(0) + " ~ " + Split(Todtemp, " ~ ")(0) + " ℃"
            Tomtemp = Split(Split(Tomtemp, " ~ ")(1), "℃")(0) + " ~ " + Split(Tomtemp, " ~ ")(0) + " ℃"
            LocalUpdate()
        Else
            _intErrCode = _intErrCodeWeather
            ErrorCheck()
            StrMsgTitle = "天气数据获取失败"
            StrMsg = "Miku无法获取天气预报的相关数据，错误信息：error code = " + Str(_intErrCode) + " /" + _strErrMsg
            FrmMsg.Show()
        End If
    End Sub

    Private Sub ErrorCheck()
        Select Case _intErrCode
            Case 1
                _strErrMsg = "服务器内部错误"
            Case 2
                _strErrMsg = "请求参数非法"
            Case 3
                _strErrMsg = "权限校验失败"
            Case 4
                _strErrMsg = "配额校验失败"
            Case 5
                _strErrMsg = "ak不存在或者非法"
            Case 101
                _strErrMsg = "服务禁用"
            Case 102
                _strErrMsg = "不通过白名单或者安全码不对"
            Case Else
                If _intErrCode >= 200 And _intErrCode < 300 Then
                    _strErrMsg = "无权限"
                ElseIf _intErrCode >= 300 And _intErrCode < 400 Then
                    _strErrMsg = "配额错误"
                End If
        End Select
    End Sub
End Module
