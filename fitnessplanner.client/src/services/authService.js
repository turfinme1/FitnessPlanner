import { jwtDecode } from "jwt-decode";

const storageState = JSON.parse(sessionStorage.getItem("authData"));

export const login = async (userData) => {
  const response = await fetch("authentication/login", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
      //   'Authorization': `Bearer ${storageState.state.accessToken}`,
    },
    body: JSON.stringify(userData),
  });

  if (response.ok) {
    const data = await response.json();
    console.log(data);
    return data;
  }
  console.log(response);
  return null;
};

export const register = async (userData) => {
  const response = await fetch("authentication/register", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(userData),
  });

  if (response.status === 201) {
    // const data = await response.json();
    console.log(response);
    // return data;
    return true;
  }

  // const errorArray = await response.json();
  // const errorMessage = errorArray.map((a) => a.description).join("\n");
  // throw new Error(errorMessage);
  return false;
};

export const logout = async () => {
  //   const response = await fetch('authentication/logout', {
  //     method: 'POST',
  //     headers: {
  //       'Content-Type': 'application/json',
  //       'Authorization': `Bearer ${storageState.state.accessToken}`,
  //     },
  //   });

  //   if (response.ok) {
  //     return true;
  //   }

  return true;
};
