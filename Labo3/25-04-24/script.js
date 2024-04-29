//escibe una funcion que encuetnre el numero más grande en un array

const arrow = () => {
  return "This is an arrow function";
};

// console.log(biggestNum([1, 16, 3, 4]));

function biggestNum(arr) {
  let localMax = 0;
  arr.forEach((e) => {
    if (e > localMax) localMax = e;
  });
  return localMax;
}

function encontrarNumeroMasGrande(arr) {
  let maximo = arr[0];
  for (const num of arr) {
    // if (num > maximo) {
    //   maximo = num;
    // }
    console.log(num);
  }
  return maximo;
}

function forIn(arr) {
  for (const num in arr) {
    console.log(arr[num]);
  }
}
// forIn(["a", "b", "c", "d"]);
// encontrarNumeroMasGrande(["a", "b", "c", "d"]);

function bubbleSort(arr) {
  for (const x in arr) {
    for (const y in arr) {
      if (arr[x] > arr[y]) {
        let temp = arr[x];
        arr[x] = arr[y];
        arr[y] = temp;
      }
    }
  }
  console.log(arr);
}

function dameVueltaLaCadena(str) {
  cadenaFinal = "";
  for (i = str.length - 1; i >= 0; i--) {
    cadenaFinal += str[i];
  }
  console.log(cadenaFinal);
}

// dameVueltaLaCadena("Hola mundo");

function factorial(num) {
  str = "";
  tot = 0;

  if (num < 0) {
    console.log("El numero ingresado no es valido");
    return;
  } else if (num == 0) {
    str += 1;
    tot = 1;
  }

  for (i = num; i > 0; i--) {
    str += i + " ";
    tot += i;
  }
  console.log(str);
  console.log(tot);
}
factorial(1);
factorial(5);
factorial(8);
factorial(0);
factorial(-5);
