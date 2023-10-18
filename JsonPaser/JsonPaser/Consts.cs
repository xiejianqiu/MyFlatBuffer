using System;
using System.Collections.Generic;
using System.Text;

namespace JsonPaser
{
    public class Consts
    {
        /// <summary>
        /// FlatBuffer表结构模型
        /// </summary>
        public const string DTTemplate = @"namespace Shark;
table FB_@{class_name_tag} {
	@{class_field_tag}
}
table FB_@{class_name_tag}Container {
	items:[FB_@{class_name_tag}];
}
root_type FB_@{class_name_tag}Container;
file_identifier" + " \"swdt\";";

        public static string FB_PROVIDER_TT = "";
        public static string FB_PROVIDER_EXPROT_TT = "";
        public static string FB_PROVIDER_LOAD_TT = "";
    }
}
