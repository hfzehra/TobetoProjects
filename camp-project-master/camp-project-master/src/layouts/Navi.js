import React, { useState } from "react";
import CartSummary from "./CartSummary";
import {  Menu, Container } from "semantic-ui-react";
import SignOut from "./SignOut";
import SingIn from "./SingIn";
import { useNavigate } from "react-router-dom";
import { useSelector } from "react-redux";

//inverted -> normal boyut demek
//fixed -> sabitleme
//container -> sağdan ve soldan boşluk bırakmamızı sağlar
//
export default function Navi() {
  //Default false -> giriş yapmammış henüz (destructred)
  const { cartItems } = useSelector((state) => state.cart);
  const [isAuthenticated, setIsAuthenticated] = useState(true);
  const history = useNavigate()
  //Çıkış yapma işlemini handle yapıyoruz.
  function handleSignOut(params) {
    setIsAuthenticated(false)
    history("/")

  }
  function handleSignIn(params) {
    setIsAuthenticated(true)
  }
  return (
    <div>
      <Menu inverted fixed="top">
        <Container>
          <Menu.Item name="home" />
          <Menu.Item name="messages" />

          <Menu.Menu position="right">
            {/* sepetde hiçbir şey yoksa sepeti gösterme  */}
            {cartItems.length>0 && <CartSummary />}
            {isAuthenticated ? <SingIn signOut={handleSignOut} /> : <SignOut signIn={handleSignIn} />}
          </Menu.Menu>
          {/* Çıkış yaptığımda ana sayfa göstersin istiyorum. Bu yüzden useHistory kullanacağız */}
        </Container>
      </Menu>
    </div>
  );
}
