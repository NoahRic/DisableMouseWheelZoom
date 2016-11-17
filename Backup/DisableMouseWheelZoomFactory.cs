using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;

namespace DisableMouseWheelZoom
{
    [Export(typeof(IWpfTextViewCreationListener ))]
    [ContentType("text")]
    [TextViewRole(PredefinedTextViewRoles.Zoomable)]
    class ViewCreationListener : IWpfTextViewCreationListener
    {
        public void  TextViewCreated(IWpfTextView textView)
        {
            textView.Options.SetOptionValue(DefaultWpfViewOptions.EnableMouseWheelZoomId, false);
        }
    }
}
