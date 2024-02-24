import React, {useState, useEffect} from "react";
import { useParams } from "react-router-dom";
import ProductService from "../services/productService";
import { Button, Card, Image } from 'semantic-ui-react'

export default function ProductDetail() {
  let { id } = useParams();

  //tek bir product aldığım için useState obje olarak alırım
  const [product, setProduct] = useState({});

  useEffect(() => {
    let productService = new ProductService();
    productService.getProductById(id).then((result) => setProduct(result.data.data));
   
  }, []);


  return (
    <div>
      Ürün : {id}
      <Card.Group>
        <Card fluid>
          <Card.Content>
            <Image
              floated="right"
              size="mini"
              src="/images/avatar/large/steve.jpg"
            />
            <Card.Header>{product.productName}</Card.Header>
            <Card.Meta>{product.categoryId}</Card.Meta>
            <Card.Description>
              Steve wants to add you to the group <strong>best friends</strong>
            </Card.Description>
          </Card.Content>
          <Card.Content extra>
            <div className="ui two buttons">
              <Button basic color="green">
                Sepete ekle
              </Button>
              <Button basic color="red">
                Sepetten çıkar
              </Button>
            </div>
          </Card.Content>
        </Card>
      </Card.Group>
    </div>
  );
}
