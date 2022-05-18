﻿namespace SzunyogvarEtterem.Models
{
    public class MenuItemModel
    {
        public int MenuItemID { get; set; }
        public string MenuItemName { get; set; }
        public int Price { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<string> CategoryList { get; set; }
    }
}
