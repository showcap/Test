﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace TestAPI.Models
{
    public static class JsonTableHelper
    {
        /// <summary>   
        /// 返回对象序列化   
        /// </summary>   
        /// <param name="obj">源对象</param>   
        /// <returns>json数据</returns>   
        public static string ToJson(this object obj)  
        {  
            JavaScriptSerializer serialize = new JavaScriptSerializer();  
            return serialize.Serialize(obj);  
        }  
  
        /// <summary>   
        /// 控制深度   
        /// </summary>   
        /// <param name="obj">源对象</param>   
        /// <param name="recursionDepth">深度</param>   
        /// <returns>json数据</returns>   
        public static string ToJson(this object obj, int recursionDepth)  
        {  
            JavaScriptSerializer serialize = new JavaScriptSerializer();  
            serialize.RecursionLimit = recursionDepth;  
            return serialize.Serialize(obj);  
        }  
  
        /// <summary>   
        /// DataTable转为json   
        /// </summary>   
        /// <param name="dt">DataTable</param>   
        /// <returns>json数据</returns>   
        public static string ToJson(DataTable dt)  
        {  
            Dictionary<string, object> dic = new Dictionary<string, object>();  
  
            int index = 0;  
            foreach (DataRow dr in dt.Rows)  
            {  
                Dictionary<string, object> result = new Dictionary<string, object>();  
  
                foreach (DataColumn dc in dt.Columns)  
                {  
                    result.Add(dc.ColumnName, dr[dc].ToString());  
                }  
                dic.Add(index.ToString(), result);  
                index++;  
            }  
            return ToJson(dic);  
        }  

    }
}