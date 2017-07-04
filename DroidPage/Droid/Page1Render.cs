using System;
using Android.Widget;
using Android.Content;
using Android.App;
using Android.Views;

//レンダー対象の指定
[assembly:Xamarin.Forms.ExportRenderer(typeof(DroidPage.Page1),typeof(DroidPage.Droid.Page1Render))]

namespace DroidPage.Droid
{
	// Page1のカスタムレンダー
	public class Page1Render : Xamarin.Forms.Platform.Android.PageRenderer
	{
		// アクティビティ
		Xamarin.Forms.Platform.Android.FormsAppCompatActivity _activity = null;

		// レイアウト
		RelativeLayout _relativeLayout = null;

		// 戻るボタン
		Android.Widget.Button _returnButton = null;

		// 初期化時
		protected override void OnElementChanged( Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Xamarin.Forms.Page> e )
		{
			// 基底処理
			base.OnElementChanged(e);

			// ContextをActivityに変換
			_activity = this.Context as Xamarin.Forms.Platform.Android.FormsAppCompatActivity;

			// レイアウトファイルからレイアウト(ビュー)を取得します
			_relativeLayout = (RelativeLayout)LayoutInflater.From( _activity ).Inflate( Resource.Layout.Page1Layout , null );

			// 戻るボタン
			_returnButton = (Android.Widget.Button)_relativeLayout.FindViewById( Resource.Id.return_button );
			_returnButton.Click += async(sender, ev) => { System.Diagnostics.Debug.WriteLine("戻るボタンをタップ"); await ((Page1)this.Element).Navigation.PopAsync(); };

			// レイアウト指定
			_activity.SetContentView( _relativeLayout );
		}

	}
}