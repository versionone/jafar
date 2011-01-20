var jasmineEnv = jasmine.getEnv();
var reporter = new jasmine.JUnitXmlReporter();

jasmineEnv.addReporter(reporter);
jasmineEnv.execute();