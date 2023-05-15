function add(x, y) {
  return x + y;
}

function subtract(x, y) {
  return x - y;
}

function multiply(x, y) {
  return x * y;
}

function divide(x, y) {
  if (y !== 0) {
    return x / y;
  } else {
    console.log("Error: Cannot divide by zero.");
    return null;
  }
}

console.log("Select an operation:");
console.log("1. Add");
console.log("2. Subtract");
console.log("3. Multiply");
console.log("4. Divide");

var choice = prompt("Enter your choice (1-4): ");

var num1 = parseFloat(prompt("Enter the first number: "));
var num2 = parseFloat(prompt("Enter the second number: "));

var result;

if (choice === "1") {
  result = add(num1, num2);
} else if (choice === "2") {
  result = subtract(num1, num2);
} else if (choice === "3") {
  result = multiply(num1, num2);
} else if (choice === "4") {
  result = divide(num1, num2);
} else {
  console.log("Invalid choice.");
  return;
}

console.log("Result: ", result);
