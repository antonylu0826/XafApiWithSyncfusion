using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace XafApiWithSyncfusion.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Document : BaseObject
    {
        public Document(Session session) : base(session) { }


        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>(nameof(Name), ref _Name, value); }
        }


        private bool _IsActive;
        public bool IsActive
        {
            get { return _IsActive; }
            set { SetPropertyValue<bool>(nameof(IsActive), ref _IsActive, value); }
        }



    }
}
