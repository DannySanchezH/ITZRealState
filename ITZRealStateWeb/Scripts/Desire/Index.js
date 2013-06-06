FB.init({ appId: 106799302860089, status: true, cookie: true });

function redeem(desc, url) {
	var obj = {
		method: 'feed',
		link: url,
		name: desc,
		description: ''
	};
	function callback(response) { }
	FB.ui(obj, callback);
}