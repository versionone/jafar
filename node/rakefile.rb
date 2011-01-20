task :default => :node

desc 'run all specs'
task :node do
  app = '../dist/jafar.exe'

	sh "#{app} environment/jafar_adapters.js require_tester.js"
end