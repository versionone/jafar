# Jafar #


[![Evil](http://content.screencast.com/users/DanLash/folders/Github/media/023c6bdd-ecd9-4332-b196-99cc9983c5f1/jafar.jpg)](http://pivotal.github.com/jasmine/)

### Evil Windows based headless Jasmine runner ###

[Jasmine](https://github.com/pivotal/jasmine) is a very simple and powerful JavaScript testing framework. It's gaining momentum very quickly and is able to run on many platforms. You can run your Jasmine tests in a browser on any operating system, and you can run it headless on mac or linux very easily but it's not so easy on Windows.

*Jafar makes running your Jasmine tests on Windows without a browser easy.*

## Usage ##

An example rake file is inlcuded in the test folder along with a example spec and source file. Use this as a basis for your own rake file.

The executable is dead simple, it reads and evaluates each of the command line arguments as JavaScript files. That's it. It does expose two global variables you can use in your scripts: file_writer and system_console.

The jafar_adapters file maps the global system_console to the more familiar 'console' global. It also creates an adapter from java's file writer (which is exposed in Rhino) to the file_writer exposed by Jafar - this is used by the junit Jasmine reporter.

If you don't have ruby / rake, here is an example running from the test directory:

`../dist/jafar.exe environment/env.therubyracer.js environment/window.js environment/jasmine.js environment/jafar_adapters.js environment/jasmine.junit_reporter.js jukebox.js specs/jukebox_specs.js environment/spec_runner.js`

## Why ##

Why do you want to run Jasmine tests on Windows headlessly? Simple: continuous integration. If your build system runs on Windows and you want to test drive your JavaScript, you __need__ it to run automatically and report results. Most build systems accept the JUnit test result format, so integrating Jafar is easy.

## How ##

Jafar is not revolutionary. In fact most of this system has already been proven in prototype form by [Jeremy Lightsmith](https://github.com/jeremylightsmith). Incorporating the Jasmine junit reporter from [Larry Myers](https://github.com/larrymyers) and the env adapter from [Charles Lowell](https://github.com/cowboyd) makes everything fit together nicely. [Rake](http://rake.rubyforge.org), [JavaScript.NET](http://javascriptdotnet.codeplex.com) and of course [V8](http://code.google.com/p/v8/) power this evil.

### Who ###

Who is Jafar anyway? He was the [evil sorcerer in the movie Aladdin](http://en.wikipedia.org/wiki/Jafar_\(Aladdin\)\#Jafar). He desired Princess Jasmine and after rejection turns to his powers to control her. We think it fits rather nicely with what this project is trying to do.
