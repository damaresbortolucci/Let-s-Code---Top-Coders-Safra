const inputText = document.querySelector("#todo-input")
const btnSubmit = document.querySelector(".btn-submit")
const todoList = document.querySelector(".todo-list")
const btnClearAll = document.querySelector(".btn-clearAll")
let id = 0;
let listToDo=[];



btnSubmit.addEventListener("click", (e)=>{
    e.preventDefault();
    const text = inputText.value

    if(text)
        createItem(text);
})



function createItem(text){

    id+=1;
    const todoItem = `
                    <li class="todo-item" id="${id}">
                        <p>
                            ${text}
                        </p>
                        <div>
                            <button 
                                class="btn-checked" 
                                onclick="checked(${id})">
                                <i class="fa fa-solid fa-check"></i>
                            </button>
                            <button 
                                class="btn-remove" 
                                onclick="remove(${id})">
                                <i class="fa fa-trash"></i>
                            </button>
                        </div>
                    </li>
                    `
    todoList.insertAdjacentHTML("beforeend", todoItem); 
    inputText.value = "";


    listToDo.push({idItem: id, item: todoItem});

    if(listToDo.length==1)
        document.querySelector(".btn-clearAll").classList.remove("hide")
}


btnClearAll.addEventListener("click", ()=>{

    const toDos = document.querySelectorAll(".todo-item")
    toDos.forEach(element => {
        element.remove()
    });

    document.querySelector(".btn-clearAll").classList.add("hide")
    listToDo=[]
})


function checked(id){
    const item = document.getElementById(id)
    item.classList.toggle("checked")
}


function remove(id){
    const item = document.getElementById(id)
    todoList.removeChild(item)
    updateList(id)
}


function updateList(id){
    listToDo = listToDo.filter(item => item.idItem !== id)

    if(listToDo.length==0)
        document.querySelector(".btn-clearAll").classList.add("hide")
}
