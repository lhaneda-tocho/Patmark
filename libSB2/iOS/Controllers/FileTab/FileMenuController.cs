// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

using ToastIOS;

using TokyoChokoku.MarkinBox.Sketchbook.Communication;

namespace TokyoChokoku.MarkinBox.Sketchbook.iOS
{
	public partial class FileMenuController : UIViewController
	{
        public CommonFileMenuSource Source { get; set; }

        public iOSFieldManager FieldManager {
            get {
                return Source.FieldManager;
            }
        }

        public FieldSource FieldSource {
            get {
                return Source.FieldSource;
            }
        }

        CommunicationNotifier CommunicationNotifier;

		public FileMenuController (IntPtr handle) : base (handle)
		{
		}

		/// <summary>
		/// Views the did load.
		/// </summary>
		override
		public void ViewDidLoad() {
			base.ViewDidLoad ();

            if (Source == null)
				throw new NullReferenceException ();

			ButtonSetup ();
			GestureSetup ();

            CommunicationNotifier = new CommunicationNotifier(1000);
            CommunicationNotifier.OnConnectionStatusChanged += (ConnectionState state, ConnectionState preState) =>
            {
                InvokeOnMainThread(() =>
                {
                    SetButtonsEnableWithConnection ( state.Ready() );
                });
            };
            CommunicationNotifier.Start();

            SetButtonsEnableWithConnection(CommunicationClientManager.Instance.IsOnline());
        }

        void SetButtonsEnableWithConnection(bool status)
        {
            NewestButton.Enabled = status;
            ControllerButton.Enabled = status;
        }

		override
		public void PrepareForSegue (UIStoryboardSegue segue, NSObject sender) {
            if (segue.Identifier.Equals ("ShowLocalFileMenu")) {
                var localFile = (UINavigationController)segue.DestinationViewController;
                var root      = (LocalFileMenuController) localFile.TopViewController;
                root.Source = Source.ToLocalFileMenuSource ();
            }
            else if (segue.Identifier.Equals ("ShowRemoteFileMenu")) {
                var localFile = (UINavigationController)segue.DestinationViewController;
                var root      = (RemoteFileMenuController) localFile.TopViewController;
                root.Source = Source.ToRemoteFileMenuSource ();
            }
		}


		void ButtonSetup () {
			NewestButton.TouchUpInside += PushNewest;
			ControllerButton.TouchUpInside += PushController;
			LocalButton.TouchUpInside += PushLocal;
		}

		void GestureSetup () {
			var tap = new UITapGestureRecognizer ( TapFieldMenuView );
			tap.NumberOfTouchesRequired  = 1;
			FileMenuView.AddGestureRecognizer (tap); 
		}


		void TapFieldMenuView ( UITapGestureRecognizer sender ) {
			PerformSegue ("Exit", this);
		}



		async void PushNewest (object sender, EventArgs arg) {
            await ControllerUtils.ActionWithLoadingOverlay(async () =>
            {
                var source = new FieldSourceFromNewest ();
                var data = await source.TryLoadAsync ();
                if (data.HasValue) {
                    // シリアル設定を読み込みます。
                    await SerialSettingsManager.Instance.Reload (null);

                    // アクションの作成と実行
                    Source.FileMenuActionSource.DidLoadNewest (source, data.Value) ();

                    Toast.MakeText (
                        "Read successfully.".Localize (),
                        ToastDuration.Medium
                    ).Show ();
                } else {
                    Toast.MakeText (
                        "File is empty.".Localize (),
                        ToastDuration.Medium
                    ).Show ();
                }
            });
		}


		void PushController (object sender, EventArgs arg) {
			
		}


		void PushLocal (object sender, EventArgs arg) {

		}

	}
}