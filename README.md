# Jafar #

### Evil Windows based headless Jasmine runner ###

Jasmine is a very simple and powerful javascript testing framework. It's gaining momentum very quickly and is able to run on many platforms. You can run your Jasmine tests in a browser on any operating system, and you can run it headless on mac or linux very easily but it's not so easy on Windows.

*Jafar makes running your Jasmine tests on Windows without a browser easy to do.*

## Why ##

Why do you want to run Jasmine tests on Windows headlessly? Simle: continuous integration. If your build system runs on Windows and you want to test drive your  javascript, you _need_ it to run automatically and report results. Most build systems accept junit test result format, so integrating Jafar is easy.

## How ##

Jafar is not revolutionary. In fact most of this system has already been proven in prototype form by Jeremy Lightsmith. Incorporating the Jasmine junit reporter from Larry Myers and the env adapter from Charles Lowell makes everything fit together nicely. Rake, Javascript.NET and of course V8 power this evil 

## Components ##

Thanks to the efforts of the developers listed below, Jafar is made possible. 

* <https://github.com/pivotal/jasmine>
* <https://github.com/jeremylightsmith/HeadlessJavascriptTestingInDotNet>
* <https://github.com/cowboyd/therubyracer>
* <http://javascriptdotnet.codeplex.com/>
* <https://github.com/larrymyers/jasmine-reporters>
* <http://rake.rubyforge.org/>

### Who ###

Who is Jafar anyway? He was the [evil sorcerer in the movie Aladdin](http://en.wikipedia.org/wiki/Jafar_\(Aladdin\)\#Jafar). He desired Princess Jasmine and after rejection turns to his powers to control her. We think it fits rather nicely with what this project is trying to do.