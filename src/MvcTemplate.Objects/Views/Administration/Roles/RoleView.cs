﻿using Datalist;
using MvcTemplate.Components.Extensions.Html;
using System;
using System.ComponentModel.DataAnnotations;

namespace MvcTemplate.Objects
{
    public class RoleView : BaseView
    {
        [Required]
        [DatalistColumn]
        [StringLength(128)]
        public String Name { get; set; }
        public Boolean MyProperty { get; set; }
        public JsTree PrivilegesTree { get; set; }

        public RoleView()
        {
            PrivilegesTree = new JsTree();
        }
    }
}
