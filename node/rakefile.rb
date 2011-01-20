task :default => :node

desc 'run all specs'
task :node do
  app = '../dist/jafar.exe'

	sh "#{app} require_tester.js"
end