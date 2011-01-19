# Jafar #

### Evil Windows based headless Jasmine runner ###

[Jasmine](https://github.com/pivotal/jasmine) is a very simple and powerful JavaScript testing framework. It's gaining momentum very quickly and is able to run on many platforms. You can run your Jasmine tests in a browser on any operating system, and you can run it headless on mac or linux very easily but it's not so easy on Windows.

*Jafar makes running your Jasmine tests on Windows without a browser easy to do.*

## Why ##

Why do you want to run Jasmine tests on Windows headlessly? Simple: continuous integration. If your build system runs on Windows and you want to test drive your JavaScript, you _need_ it to run automatically and report results. Most build systems accept the JUnit test result format, so integrating Jafar is easy.

## How ##

Jafar is not revolutionary. In fact most of this system has already been proven in prototype form by [Jeremy Lightsmith](https://github.com/jeremylightsmith). Incorporating the Jasmine junit reporter from [Larry Myers](https://github.com/larrymyers) and the env adapter from [Charles Lowell](https://github.com/cowboyd) makes everything fit together nicely. [Rake](http://rake.rubyforge.org), [JavaScript.NET](http://javascriptdotnet.codeplex.com) and of course [V8](http://code.google.com/p/v8/) power this evil.

### Who ###

Who is Jafar anyway? He was the [evil sorcerer in the movie Aladdin](http://en.wikipedia.org/wiki/Jafar_\(Aladdin\)\#Jafar). He desired Princess Jasmine and after rejection turns to his powers to control her. We think it fits rather nicely with what this project is trying to do.