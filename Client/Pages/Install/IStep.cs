using Microsoft.AspNetCore.Components;

namespace AuthServer.Client.Pages.Install
{
    public interface IStep
    {
        [Parameter]
        InstallStateMachine StateMachine { get; set; }
    }
}
