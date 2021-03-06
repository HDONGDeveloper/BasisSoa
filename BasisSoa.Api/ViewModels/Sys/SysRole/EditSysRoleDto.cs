﻿using BasisSoa.Common.TreeHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasisSoa.Api.ViewModels.Sys
{
    public class EditSysRoleDto
    {
        /// <summary>
        /// 父ID
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 组织ID
        /// </summary>   
        public string OrganizeId { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 中文名称
        /// </summary>  
        public string FullName { get; set; }
        /// <summary>
        /// 英文名称
        /// </summary>
        public string FullNameEn { get; set; }


        /// <summary>
        /// 是否默认展开
        /// </summary>
        public bool IsExpand { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int SortCode { get; set; }
        /// <summary>
        /// 是否有效
        /// </summary>
        public bool EnabledMark { get; set; }



        //**********额外的
        public List<CommonTreeModel> treeModels { get; set; }

}
}
