task :default => :specs

desc 'run all specs'
task :specs do

	env_files = ['environment/env.therubyracer.js', 'environment/window.js', 'environment/jasmine.js', 'environment/jafar_adapters.js', 'environment/jasmine.junit_reporter.js'].join(' ')
	source_files = ['jukebox.js'].join(' ')
	spec_files = ['specs/jukebox_specs.js'].join(' ')

	runner = 'environment/spec_runner.js'
	app = '../dist/jafar.exe'

	sh "#{app} #{env_files} #{source_files} #{spec_files} #{runner}"
end