import { ADD_TO_CART, REMOVE_FROM_CART } from "../actions/cartActions";
import { cartItems } from "../initialValues/cartItems";

//birden fazla başlangıç değeri olabilir bu yüzden değer belirledik
const initialState ={
    cartItems:cartItems
}

export default function cartReducer(state=initialState,{type,payload}){
    switch (type) {
        case ADD_TO_CART:
            let product = state.cartItems.find(c=>c.product.id === payload.id)  
            if (product) {
                product.quantity++;
                //referansının değişmesi gerekiyor ki ürün eklendiğini anlayabilelim
                return{
                    ...state
                }
            } else {
                //yeni değer oluşturma
                return{
                    ...state,
                    cartItems:[...state.cartItems,{quantity:1,payload:product}]
                }
            }          
            
            //2:13:00
        case REMOVE_FROM_CART:
            return{
                //silinen hariç diğer ürünler için filter ile yeni array oluştururuz.
                ...state,
                cartItems:state.cartItems.filter(c=>c.product!==payload.id)
            }
        default:
            return state;
    }
}
