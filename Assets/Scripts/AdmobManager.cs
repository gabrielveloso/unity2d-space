using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdmobManager : MonoBehaviour
{
     private BannerView bannerView;

     public static AdmobManager instance;
    // Start is called before the first frame update

    private void Awake()
	{
		if(instance == null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else if(instance != this)
		{
			Destroy(gameObject);
		}
	}

    void Start()
    {
        #if UNITY_ANDROID
		string appId = "ca-app-pub-3032141665697361~6686831389";
#elif UNITY_IPHONE
            string appId = "ca-app-pub-9785533804332092~9517523520";
#else
            string appId = "unexpected_platform";
#endif
        MobileAds.Initialize(initStatus => { });

         this.RequestBanner();
    }

     private void RequestBanner()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3032141665697361/6303688002";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

         // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }
}
