// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;
using System.Globalization;

namespace System.Drawing.Design
{

    public interface IPropertyValueUIService
    {
        PropertyValueUIItem[] GetPropertyUIValueItems(object source, PropertyDescriptor propertyInfo);
        string ToolTip { get; }

        event EventHandler PropertyUIValueItemsChanged; // { add; remove; } // -= new EventHandler(this.OnNotifyPropertyValueUIItemsChanged);
    }

    public class PropertyValueUIItem
    {
        public virtual void InvokeHandler(object source, PropertyDescriptor propertyInfo, PropertyValueUIItem pvUIItem) { }
        public virtual void Reset() { }

        public string ToolTip { get; protected set; }
        public Image Image { get; protected set; }
    }


    /*
        Severity Code    Description Project File Line    Suppression State
    Error CS0433  The type 'PermissionState' exists in both 'System.Runtime.Extensions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
    and 'System.Security.Permissions, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'	
    System.Windows.Forms E:\Beta\mono02\winforms\src\System.Windows.Forms\src\System\Windows\Forms\AxHost.cs	3584	Active
    */

    public enum UITypeEditorEditStyle
    {
        Modaless = 0,
        Modal = 1,
        DropDown = 2
    }

    public class PaintValueEventArgs : EventArgs
    {
        public PaintValueEventArgs(params object[] args)
        {
        }
    }

    internal abstract class UITypeEditor
    {
        public virtual object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value) => null;
        public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) => null;

        public virtual UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) => UITypeEditorEditStyle.Modal;
        public virtual UITypeEditorEditStyle GetEditStyle() => UITypeEditorEditStyle.Modal;

        public virtual bool GetPaintValueSupported(ITypeDescriptorContext context) => false;

        public virtual void PaintValue(PaintValueEventArgs e) { }

        // 
        public bool IsDropDownResizable { get; set; }
    }
}
