(function(){
	/* adapter between rhino's file writer and jafar's file_writer */
	java = {}
	java.io = {}

	java.io.BufferedWriter = function(writer){
		this.write = function(text){
			file_writer.write(writer.filename, text) //auto closed
		};

		this.close = function(){};
	};

	java.io.FileWriter = function(filename){
		this.filename = filename;
	};

	/* adapter between console and jafar's system_console */
	console = system_console
})();