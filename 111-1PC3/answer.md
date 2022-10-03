# 第3次練習-練習-PC3
>
>學號：109111139
><br />
>姓名：繆昊廷 
><br />
>作業撰寫時間：25mins
><br />
>最後撰寫文件日期：2022/10/03
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容


下段程式碼則為使用後結果：顯示衣服、帽子、褲子加起來的總價格

```csharp
protected void Page_Load(object sender, EventArgs e)
        {
            int i_Clothes = 7;
            int i_Hat = 8;
            int i_Pants = 9;
            int total = 300 * i_Clothes + 350 * i_Hat + 400 * i_Pants;
            Response.Write(total);
        }
```


下段程式碼則為使用後結果：無

```html
<%@ Page Language="C#" AutoEventWireup="true" ...>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" ...>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
```


## 個人認為完成作業須具備觀念

需要了解如何宣告變數，像數字就用int，程式執行時會將數字帶入宣告的變數，計算時將變數乘以價格，最後會得到題目要的答案。

