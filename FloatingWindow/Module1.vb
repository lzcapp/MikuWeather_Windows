Imports System.Net
Imports System.Text
Imports System.Xml
Imports Newtonsoft.Json.Linq

Module Module1
    Public strSetLoc, strSetWeather As String
    Public intSetIntv, intSource As Integer

    Public ip, iploc As String
    Public StrMsg As String
    Public StrMsgTitle As String

    Public strSetAddr As String
    Public blnAutoIPLoc, blnIPSer, blnWeatherSer As Boolean

    Public todweather, tomweather, nowtemp, todtemp, tomtemp, toddaypic, tomdaypic, todevepic, tomevepic As String
    Public strCloDs, strClo, strCarDs, strCar, strTraDS, strTra, strSicDs, strSic, strSpoDS, strSpo, strUVDs, strUV As String
    Public intPM As Integer
    Public strWind As String

    Dim joLoc, joWeather As JObject
    Public intErrCodeIP, intErrCodeWeather, intErrCode As Integer
    Public strErrMsg As String

    Public Sub IPLocation()
        Dim strLocNet As String
        Try
            'Using webcIP As New WebClient
            'webcIP.Encoding = Encoding.Default
            'ip = webcIP.DownloadString("http://www.whatsmyip.us/showipsimple.php")
            'ip = ip.Substring(16)
            'ip = ip.Remove(ip.Length - 3)
            'End Using

            Using webcIPloc As New WebClient
                webcIPloc.Encoding = Encoding.Default
                strLocNet = webcIPloc.DownloadString("http://api.map.baidu.com/location/ip?ak=edUWu66ddGavrmj9a6vcsa75")
            End Using

            joLoc = JObject.Parse(strLocNet)

            intErrCodeIP = Int(joLoc.SelectToken("status").ToString)
            If intErrCodeIP = 0 Then
                iploc = Split(joLoc.SelectToken("content.address_detail.city").ToString, "市")(0)
            Else
                intErrCode = intErrCodeIP
                ErrorCheck()
                StrMsgTitle = "IP定位失败"
                StrMsg = "Miku无法获取您的位置，错误信息：error code = " + Str(intErrCode) + " /" + strErrMsg
                frmMsg.Show()
            End If

        Catch ex As Exception
            StrMsgTitle = "Miku似乎遇到麻烦了！"
            StrMsg = "Mod1异常：" + ex.Message
            frmMsg.Show()
        End Try
    End Sub

    Public Sub GetWeatherData()
        Dim strWeatherNet As String
        Try
            'If 
            Using weatherWebc As New WebClient
                weatherWebc.Encoding = Encoding.UTF8
                strWeatherNet = weatherWebc.DownloadString("http://api.map.baidu.com/telematics/v3/weather?location=" + strSetLoc + "&output=json&ak=edUWu66ddGavrmj9a6vcsa75")
            End Using

            joWeather = JObject.Parse(strWeatherNet)

            intErrCodeWeather = joWeather.SelectToken("error").ToString
            If intErrCodeWeather = 0 Then
                intPM = Int(joWeather.SelectToken("results[0].pm25").ToString)

                strWind = joWeather.SelectToken("results[0].weather_data[0].wind").ToString

                nowtemp = Split(Split(joWeather.SelectToken("results[0].weather_data[0].date").ToString, "：")(1), "℃")(0)

                toddaypic = joWeather.SelectToken("results[0].weather_data[0].dayPictureUrl").ToString
                todevepic = joWeather.SelectToken("results[0].weather_data[0].nightPictureUrl").ToString
                todweather = joWeather.SelectToken("results[0].weather_data[0].weather").ToString
                todtemp = joWeather.SelectToken("results[0].weather_data[0].temperature").ToString

                tomdaypic = joWeather.SelectToken("results[0].weather_data[1].dayPictureUrl").ToString
                tomevepic = joWeather.SelectToken("results[0].weather_data[1].nightPictureUrl").ToString
                tomweather = joWeather.SelectToken("results[0].weather_data[1].weather").ToString
                tomtemp = joWeather.SelectToken("results[0].weather_data[1].temperature").ToString

                strCloDs = joWeather.SelectToken("results[0].index[0].zs").ToString
                strClo = joWeather.SelectToken("results[0].index[0].des").ToString
                strCarDs = joWeather.SelectToken("results[0].index[1].zs").ToString
                strCar = joWeather.SelectToken("results[0].index[1].des").ToString
                strTraDS = joWeather.SelectToken("results[0].index[2].zs").ToString
                strTra = joWeather.SelectToken("results[0].index[2].des").ToString
                strSicDs = joWeather.SelectToken("results[0].index[3].zs").ToString
                strSic = joWeather.SelectToken("results[0].index[3].des").ToString
                strSpoDS = joWeather.SelectToken("results[0].index[4].zs").ToString
                strSpo = joWeather.SelectToken("results[0].index[4].des").ToString
                strUVDs = joWeather.SelectToken("results[0].index[5].zs").ToString
                strUV = joWeather.SelectToken("results[0].index[5].des").ToString

                LocalUpdate()
            Else
                intErrCode = intErrCodeWeather
                ErrorCheck()
                StrMsgTitle = "天气数据获取失败"
                StrMsg = "Miku无法获取天气预报的相关数据，错误信息：error code = " + Str(intErrCode) + " /" + strErrMsg
                frmMsg.Show()
            End If

        Catch ex As Net.WebException
            StrMsgTitle = "Miku似乎遇到麻烦了！"
            StrMsg = "好像网络坏掉了o(>﹏<)o！ Mod1异常：" + ex.Message
            frmMsg.Show()
            frmShow.LinkLabel3.Text = "No Data"
            frmShow.LinkLabel4.Text = "No Data"
        Catch ex As EntryPointNotFoundException
            StrMsgTitle = "Miku似乎遇到麻烦了！"
            StrMsg = "您的网络似乎有问题？ Mod1异常：" + ex.Message
            frmMsg.Show()
            frmShow.LinkLabel3.Text = "No Data"
            frmShow.LinkLabel4.Text = "No Data"
        Catch ex As Exception
            StrMsgTitle = "Miku似乎遇到麻烦了！"
            StrMsg = "Mod1异常：" + ex.Message
            frmMsg.Show()
        End Try
    End Sub

    Public Sub ErrorCheck()
        If intErrCode = 1 Then
            strErrMsg = "服务器内部错误"
        ElseIf intErrCode = 2 Then
            strErrMsg = "请求参数非法"
        ElseIf intErrCode = 3 Then
            strErrMsg = "权限校验失败"
        ElseIf intErrCode = 4 Then
            strErrMsg = "配额校验失败"
        ElseIf intErrCode = 5 Then
            strErrMsg = "ak不存在或者非法"
        ElseIf intErrCode = 101 Then
            strErrMsg = "服务禁用"
        ElseIf intErrCode = 102 Then
            strErrMsg = "不通过白名单或者安全码不对"
        ElseIf intErrCode >= 200 And intErrCode < 300 Then
            strErrMsg = "无权限"
        ElseIf intErrCode >= 300 And intErrCode < 400 Then
            strErrMsg = "配额错误"
        End If
    End Sub
End Module
