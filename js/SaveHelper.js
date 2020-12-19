

function ExportSave(slotKey) {
	var exportSaved = localStorage.getItem(slotKey);
	var file = new Blob([exportSaved], { type: "text/plain" });
	if (
		window.navigator.msSaveOrOpenBlob // IE10+
	)
		window.navigator.msSaveOrOpenBlob(file, "Madnathsave.txt");
	else {
		// Others
		var a = document.createElement("a"),
			url = URL.createObjectURL(file);
		a.href = url;
		a.download = "Madnathsave.txt";
		document.body.appendChild(a);
		a.click();
		setTimeout(function () {
			document.body.removeChild(a);
			window.URL.revokeObjectURL(url);
		}, 0);
	}
}

function GetItem(slotKey) {
	let keydata = localStorage.getItem(slotKey);
    if (keydata == "undefined") return undefined;
    return JSON.parse(keydata);
}