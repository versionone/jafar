var Jukebox = (function(){
	var self = {}, 
		_songs = [];

	self.init2 =  function(){
		_songs = [];
	};

	self.listSongs = function(){
		return _songs;
	};

	self.addSong = function(artist, title){
		var song = { Artist: artist, Title: title };

		_songs.push(song);

		return song;
	};

	return self;
}());