import React from "react";
import { Dropdown, DropdownMenu, Menu, Image } from "semantic-ui-react";

export default function SingIn({signOut}) {
  return (
    <div>
      <Menu.Item>
        <Image avatar spaced="right" src="https://lh3.googleusercontent.com/ogw/ANLem4aIjmjnQp12mMKZ92VHP-Ax0356vM7dMxCc63YV7g=s32-c-mo"></Image>
        <Dropdown pointing="top left" text="Zehra">
          <DropdownMenu>
            <Dropdown.Item text="Bilgilerim" icon="info"/>
            <Dropdown.Item onClick={signOut} text="Çıkış Yap" icon="sign-out"/>
          </DropdownMenu>
        </Dropdown>
      </Menu.Item>
    </div>
  );
}
