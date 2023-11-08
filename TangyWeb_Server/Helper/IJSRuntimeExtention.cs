using Microsoft.JSInterop;

namespace TangyWeb_Server.Helper
{
    public static class IJSRuntimeExtention
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToasrt","Success", message);
        }
    }
}
