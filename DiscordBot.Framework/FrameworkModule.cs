using Autofac;
using DiscordBot.Framework.BootSteps;
using DiscordBot.Framework.Buttons;
using DiscordBot.Framework.Contract.Boot;
using DiscordBot.Framework.Interpretors.DateTime;

namespace DiscordBot.Framework;

public class FrameworkModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterModule<BootModule>();
        builder.RegisterModule<DateTimeInterpretorModule>();
        builder.RegisterType<ButtonManager>().As<IBootStep>();
    }
}