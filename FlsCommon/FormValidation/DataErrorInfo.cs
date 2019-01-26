using System.ComponentModel;

namespace FlsCommon.FormValidation
{
    public abstract class DataErrorInfo : IDataErrorInfo
    {
        string IDataErrorInfo.Error => DataErrorInfoHelper.GetErrorInfo(this);

        string IDataErrorInfo.this[string columnName] => DataErrorInfoHelper.GetErrorInfo(this, columnName);
    }
}