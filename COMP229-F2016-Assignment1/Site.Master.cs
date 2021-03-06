﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/**
 * This is a mini profile extended web application which is all about Md Mamunur Rahman 
 * 
 * @FileName: Projects.aspx.cs
 * @Author Md Mamunur Rahman
 * @student ID: 300872772
 * @Last Update 30-September-2016
 * @website: http://mamun-portfolio.azurewebsites.net/Default.aspx
 * @description: this file is main cs file for the website
 */
namespace COMP229_F2016_Assignment1
{
    /**  
* <summary>  
* This is the Site class for Site.Master page.  
* </summary>  
*   
* @class Site  
*/
    public partial class Site : System.Web.UI.MasterPage
    {

        //PROTECTED METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the protected method for for loading Contact page code
        * </summary>
        * 
        * @method Page_Load
        * @returns {void} 
        * @param {object} sender
        * @param {EventArgs} e
        */
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Page.Title)
            {

                case "Home":
                    Home.Attributes.Add("class", "active");
                    break;
                case "Projects":
                    Projects.Attributes.Add("class", "active");
                    break;
                case "Services":
                    Services.Attributes.Add("class", "active");
                    break;
                case "Biography":
                    Biography.Attributes.Add("class", "active");
                    break;
                case "Contacts":
                    Contacts.Attributes.Add("class", "active");
                    break;



            }

        }
    }
}