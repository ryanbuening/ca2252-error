
using Microsoft.AspNetCore.Components.Forms;

namespace CA2252.AD0001;

public partial class Error
{
	public EditContext EditContext { get; }

	public Error()
	{
		EditContext = new EditContext(""); // CA2252 - AD0001 error
	}
}