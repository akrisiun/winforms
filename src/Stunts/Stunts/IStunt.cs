using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Stunts
{
    /// <summary>
    /// Interface implemented by all stunts.
    /// </summary>
    // These attributes prevent registering the "Implement through behavior pipeline" codefix.
    // See CustomMockCodeFixProvider and its base class CustomStuntCodeFixProvider.
    // [GeneratedCode("Stunts", "5.0")]
    [GeneratedCode("Stunts", "5.0")] // ThisAssembly.Metadata.Version)]
    [CompilerGenerated]
    public interface IStunt
	{
        /// <summary>
        /// Behaviors configured for the stunt.
        /// </summary>
		ObservableCollection<IStuntBehavior> Behaviors { get; }
	}
}
