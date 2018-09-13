using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    /*
     * 取得 Cookie 資料要使用 Request.Cookie
     * 
     * 設定 Cookie 資料要使用 Response.Cookie.Add( ... )
     */

    protected void Page_Load(object sender, EventArgs e)
    {
        this.DisplayCookieValue();
    }

    protected void GenerateCookieButton_Click(object sender, EventArgs e)
    {
        string _value;

        _value = this.CookieValueTextBox.Text;

        if (string.IsNullOrWhiteSpace(_value) == true)
            return;

        this.CookieValue = _value;

        this.DisplayCookieValue();
    }

    private void DisplayCookieValue()
    {
        this.CookieValueLiteral.Text = this.CookieValue;
    }


    const string CookieValueName = "_cookie_value";

    private string CookieValue
    {
        get
        {
            if (Request.Cookies[CookieValueName] == null)
                return string.Empty;

            return Request.Cookies[CookieValueName].Value;
        }
        set
        {
            HttpCookie _cookie;
            
            if(Request.Cookies[CookieValueName] == null)
            {
                _cookie = new HttpCookie(CookieValueName);
                _cookie.HttpOnly = true;
            }
            else
            {
                _cookie = Request.Cookies[CookieValueName];
            }

            _cookie.Value = value;

            //設定 HttpCookie 需要使用 Response.Cookie.Add ...
            Response.Cookies.Add(_cookie);
        }
    }

}