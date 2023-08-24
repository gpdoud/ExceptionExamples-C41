
using ExceptionExamples_C41;

try {
    method1();
} catch (Exception ex) {

}

void method1() {
    method2();
}

void method2() {
    method3();
}

void method3() {
    method4();
}

void method4() {
    var d = 0;
    var e = 1 / d;
}
