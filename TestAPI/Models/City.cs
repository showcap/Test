using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace TestAPI.Models
{
    /// <summary>
    /// 业主城市 的实体类
    /// </summary>
    [DataContract(Namespace="")]
    
    public class City
    {
        private int cityID;
        /// <summary>
        /// 城市ID
        /// </summary>

        [DataMember]
        public int CityID
        {
            get
            {
                return cityID;
            }
            set
            {
                cityID = value;
            }
        }
        private string cityName;
        /// <summary>
        /// 城市名称
        /// </summary>
       [DataMember]
        public string CityName
        {
            get
            {
                return cityName;
            }
            set
            {
                cityName = value;
            }
        }
        private int cityArea;
        /// <summary>
        /// 所属区域
        /// </summary>
        public int CityArea
        {
            get
            {
                return cityArea;
            }
            set
            {
                cityArea = value;
            }
        }
        private int pID;
        /// <summary>
        /// 父节点ID
        /// </summary>
        public int PID
        {
            get
            {
                return pID;
            }
            set
            {
                pID = value;
            }
        }
        private string fullLevel;
        /// <summary>
        /// 以,分隔的层次全路径，从左到右依次为父子关系
        /// </summary>
        public string FullLevel
        {
            get
            {
                return fullLevel;
            }
            set
            {
                fullLevel = value;
            }
        }
        private string shortName;
        /// <summary>
        /// 简写
        /// </summary>
        public string ShortName
        {
            get
            {
                return shortName;
            }
            set
            {
                shortName = value;
            }
        }
        private DateTime releaseTime;
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime ReleaseTime
        {
            get
            {
                return releaseTime;
            }
            set
            {
                releaseTime = value;
            }
        }
        private string unionName;
        /// <summary>
        /// 组合名称
        /// </summary>
        public string UnionName
        {
            get { return unionName; }
            set { unionName = value; }
        }


    }
}