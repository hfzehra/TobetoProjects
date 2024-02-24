import React from "react";
import Categories from "./Categories";
import ProductList from "../pages/ProductList";
import { Grid } from "semantic-ui-react";
import { Route, Routes } from "react-router-dom";
import ProductDetail from "../pages/ProductDetail";
import CartDetail from "../pages/CartDetail";
import { ToastContainer } from "react-toastify";

//Layout aslında sabit olan kısımlardır
//.js ve .jsx arasında fark yok ikiside kullanılabilir.

export default function Dashboard() {
  return (
    <div>
      <ToastContainer position="bottom-right"/>
      <Grid>
        <Grid.Column width={4}>
          <Categories />
        </Grid.Column>
        <Grid.Column width={12}>
          <Routes>
            {/* Birbirinden farklı sayfalar ise exact kullanılyoruz */}
            <Route exact path="/" Component={ProductList} />
            <Route path="/products/:id" Component={ProductDetail} />
            <Route exact path="/cart" Component={CartDetail} />
          </Routes>
        </Grid.Column>
      </Grid>
    </div>
  );
}
