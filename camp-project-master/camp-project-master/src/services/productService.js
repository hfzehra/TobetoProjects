import axios from "axios"

export default class ProductService{
  getProduct(){
    return axios.get("http://localhost:5056/api/Products/getall")
  }

  getProductById(productId){
    return axios.get("http://localhost:5056/api/Products/getbyid?id="+productId)
  }
}
