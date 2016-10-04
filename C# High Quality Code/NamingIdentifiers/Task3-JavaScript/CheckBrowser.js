function checkBrowser(event, arguments) {
  var currentTab = window,
      browser = currentTab.navigator.appCodeName,
      isMozilla = (browser === "Mozilla");

  if(isMozilla) {
    alert("Yes");
  } else {
    alert("No");
  }
}