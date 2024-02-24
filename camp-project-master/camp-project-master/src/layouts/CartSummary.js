import React from "react";
import { useSelector } from "react-redux";
import { NavLink } from "react-router-dom";
import { Dropdown, DropdownDivider, Label } from "semantic-ui-react";

export default function CartSummary() {
  const { cartItems } = useSelector((state) => state.cart);
  return (
    <div>
      <Dropdown item text="Sepetiniz">
        <Dropdown.Menu>
          {cartItems.map((cartItems) => (
            <Dropdown.Item>
              {cartItems.product.productName}
              <Label>{cartItems.quantity}</Label>
            </Dropdown.Item>
          ))}
          <DropdownDivider></DropdownDivider>
          <Dropdown.Item as={NavLink} to="/cart">
            Sepete git
          </Dropdown.Item>
        </Dropdown.Menu>
      </Dropdown>
    </div>
  );
}
