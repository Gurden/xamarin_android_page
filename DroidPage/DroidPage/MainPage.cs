using System;
using Xamarin.Forms;

namespace DroidPage
{
	// メインページ
	public class MainPage : ContentPage
	{
		// オブジェクト
		AbsoluteLayout _pageLayout = null; // ページレイアウト
		Button _nextButton         = null; // 遷移ボタン(進む)

		// コンストラクタ
		public MainPage()
		{
			// ページレイアウト
			_pageLayout = new AbsoluteLayout();

			// 遷移ボタン(進む)
			_nextButton = new Button { Text="現在はXamarin.Formsページです。\nこのボタンタップでAndroidページに遷移" };
			_nextButton.Clicked += async(sender, e) => { await this.Navigation.PushAsync( new Page1() ); };

			// オブジェクト配置
			_pageLayout.Children.Add( _nextButton );

			// ページにレイアウト指定
			this.Content = _pageLayout;
		}




		// 画面サイズが決定した直後
		protected override void OnSizeAllocated( double width , double height )
		{
			// 基底処理
			base.OnSizeAllocated( width, height );

			// 遷移ボタン
			_nextButton.WidthRequest = width;
			_nextButton.HeightRequest = height * 0.5;
			_nextButton.TranslationX = 0.0;
			_nextButton.TranslationY = 0.0;
		}


	}
}