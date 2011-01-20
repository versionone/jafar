var exports = {}; 
function require(filename) { 
	var script = file_loader.load(filename);
	if (script)	eval(script); 
	return exports; 
}; 
