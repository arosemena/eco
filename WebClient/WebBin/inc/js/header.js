// Get URL Parameters - Relative protocol, domain, port
let url = window.location.href;
let arr = url.split("/");
let result = arr[0] + "//" + arr[2];
let APPIQUERYURL = result;
let ACCOUNTAPPIQUERYURL = "https://ecoauth.strangeloopgames.com/";

function getURLParameter(name) {
	return decodeURIComponent((new RegExp('[?|&]' + name + '=' + '([^&;]+?)(&|#|;|$)').exec(location.search)||[,""])[1].replace(/\+/g, '%20'))||null
}

String.prototype.escapeQuotes = function() {
    return this.replace(/(["'])/g, "\\$1");
};

String.prototype.strip = function() {
    let tmp = document.implementation.createHTMLDocument("New").body;
    tmp.innerHTML = this;
    return tmp.textContent || tmp.innerText || "";
};