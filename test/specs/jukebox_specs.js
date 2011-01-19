describe('jukebox', function(){
	it('should be available', function(){
		expect(Jukebox).toBeDefined();
	})

	it('should be initializable', function(){
		expect(Jukebox.init).toBeDefined();
	});

	describe('listing available songs', function(){
		var songs;

		beforeEach(function(){
			songs = Jukebox.listSongs();
		});

		it('should have no songs', function(){
			expect(songs.length).toBe(0);
		})
	})

	describe('adding a song', function(){
		var song;
		var songs;

		beforeEach(function(){
			Jukebox.init();
			song = Jukebox.addSong('Jay-Z', 'Empire State of Mind');
			songs = Jukebox.listSongs();
		});

		it('should return the song with artist and title', function(){
			expect(song.Artist).toBeDefined()
			expect(song.Title).toBeDefined()
		});

		it('should have one song', function(){
			expect(songs.length).toBe(1);
		});

		it('should have the song that was added', function(){
			expect(songs[0].Artist).toBe('Jay-Z');
			expect(songs[0].Title).toBe('Empire State of Mind');
		});
	})
});
