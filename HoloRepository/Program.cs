using FellowOakDicom;
using FellowOakDicom.Imaging;
using FellowOakDicom.Imaging.Codec;

namespace HoloRepository
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            new DicomSetupBuilder()
                .RegisterServices(s =>
                    s.AddFellowOakDicom()
                     .AddImageManager<ImageSharpImageManager>()
                     .AddTranscoderManager<FellowOakDicom.Imaging.NativeCodec.NativeTranscoderManager>())
                .SkipValidation()
                .Build();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}