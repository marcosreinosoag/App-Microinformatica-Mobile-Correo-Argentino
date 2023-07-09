TITULO: Volarg

Sobre Mi: Soy Marcos Reinoso tengo 25 años trabajo en el correo Argentino de Soporte Tecnico y mi idea a futuro es cambiarme para la parte de programacion.
Arranque programando en la secundaria Tecnica de Monte Grande. Desde el tercer año en adelante fue todo programacion(Visual basic, Qbasic, Html, css,Base de datos, etc)Me gustaba bastante la parte de pensar demasiado la logica y resolver los ejercicios que nos daban. Termine la tecnica pero no segui con programacion.
Hace dos años arranque la facultad y si bien se complica con el laburo hago lo posible para dedicarle un tiempo a las materias.
El parcial estuvo bueno hubo partes que le mande basatante logica como: Vender pasaje despues el resto estuvo entretenido y si bien soy recursante aprendi bastantes cosas.

Resumen:

-Loguin: La aplicacion comienza con un loguin en el cual se introduce el nombre dni(Usuario) del vendedor y la contraseña para ingresar, tambien tiene un boton que rellena automaticamente los datos y facilita el ingreso.

Menu Principal: contiene a primera vista los vuelos que estan cargados en el sistema, si se hace doble clic sobre un vuelo en vigencia lo lleva al formulario InformacionVuelo, ademas en la parte superior tiene un submenu que realiza diferentes tareas depende lo solicitado.

InformacionVuelo:permite ver la informacion del vuelo seleccionado, posee tres botones tanto para realizar la venta de pasajes como tambien para ver los pasajeros o el equipaje cargado.

Diagrama De Clases:

![image](https://user-images.githubusercontent.com/68253845/193736693-48019cc0-093f-4bab-a0e5-4f9b03059410.png)

Justificacion Tecnica:

- Clases y métodos estáticos

Clases estaticas: se utilizo la clase Volarg como clase estatica para poder implementar desde cualcuier parte del codigo una lista o un metodo estatico perteneciente a la clase Volarg, para no tener que instanciar un objeto del tipo Volarg y acceder a sus metodos o atributos. Tambien se implemento una clase estatica en la clase validaciones.

- Programación orientada a objetos

Se utilizaron clases y objetos en todo el proyecto (ejemplo clase Vendedor)

Se creo la clase Vendedor tomandola como molde o plantilla, dentro se crearon los atributos primordiales aplicando encapsulamiento y marcandolos como private, se aplico abstraccion dejando de lado las caracteristicas inecesarias por ejemplo(Altura, peso). Se crearon objetos del tipo vendedor cada uno con caracteristicas distintas. Se aplico herencia entre las clases Persona, Vendedor y Pasajero. y se utilizo polimorfismo creando el metodo public abstract string MostrarDatos();

- Sobrecarga

Se uso sobrecarga en el constructor de la clase Aerenave porque cuando se hardcodea un vuelo es necesario asignarle un avion, instancia un objeto del tipo Aereonave y se necesita pasale un array cargado con pasajeros, en cambio cuando se instancia un aereonave y no esta asociada a ningun vuelo no es necesario pasarle un array.Por eso mismo un constructor recibe un array de pasajeros y el otro no.
La Sobrecarga de metodos fue utilizada en la clase validar donde el metodo public static string ValidarStringSoloNumerosConComa(string cadenaParaAnalizar, int minimo) se utiliza para validar si un string compuesto por un numero con coma era valido y es mayor a un numero. Luego se encontro la necesidad de validar un string que contiene un numero con coma que este entre el minimo indicado y el maximo por esto llegue a la conclucion que tenia que hacer una sobre carga y crear el metodo: public static string ValidarStringSoloNumerosConComa(string cadenaParaAnalizar, int minimo, int maximo) y asi cumplir con la necesidad y reutilizar codigo. 

- Windows Forms

Se utilizo Windows Forms para crear la vista con la que va a interactuar el vendedor, tambien fueron de gran ayuda las herramientas que disponen los form (DataGridView, Button, texbox, label, entre otras).

- Colecciones

Se usaron listas (Ejemplo: Clase Volarg linea 8 a linea 11) para poder cargar: todos los vuelos, el historial de los pasajeros, los vendedores y los aviones en el sistema. Se utillizaron listas porque no se sabe con exactitud la cantidad de vendedores, vuelos, pasajeros o aviones van a cargarse en el sistema y como son dinamicas nos permiten cargar el tipo de dato indicado sin necesidad de saber el limite exacto.   
Tambien hay un diccionario de equipajes y pasajeros que contiene todos los equipajes cargados en el sistema relacionandolos con cada pasajero.

- Encapsulamiento

Herencia

Se realizo la herencia entre la clase persona(Clase Base) y las clases Pasajero(Clase Derivada) y Vendedor(Derivada).Esta herencia fue creada porque el vendedor y el pasajero estan relacionadas desienden de una persona. La clase persona le que proporciona funcionalidad específica y comportamiento) a sus clases derivadas que lo heredan.

- Polimorfismo y clases abstractas

La clase Pesona se utilizo como abstracta ya no se requiere por ningun motivo crear e instancia un objeto del tipo Persona, se incluyo el polimorfisto creando el metodo public abstract string MostrarDatos() que obliga a las clases derivadas implementar si o si el metodo y utilizarlo de distintas maneras. 

Propuesta de valor agregado:

![image](https://user-images.githubusercontent.com/68253845/193799390-48ecccb3-5a75-45f8-8c69-6cda70fb61bc.png)
Se utilizo el evento Mouse Hover para indicar los errores cuando se ingresa un dato, pasando el mouse encima del boton de error te muestra el error.


Gracias.

