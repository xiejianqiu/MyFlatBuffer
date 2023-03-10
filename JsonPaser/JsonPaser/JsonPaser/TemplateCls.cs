using System.Collections.Generic;

namespace JsonPaser
{
    public class TemplateCls 
    {
        public string mClassName;
        public string mRelativePath;
        public List<ClsField> mFields;

        public TemplateCls(string mClassName, string mRelativePath)
        {
            this.mClassName = mClassName;
            this.mRelativePath = mRelativePath;
            mFields = new List<ClsField>();
        }

        public void AddField(ClsField f)
        {
            mFields.Add(f);
        }
    }
}
