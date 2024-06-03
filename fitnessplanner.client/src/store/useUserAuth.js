import { create } from "zustand";
import { createJSONStorage, persist } from "zustand/middleware";
import * as authService from "../services/authService";
import { jwtDecode } from "jwt-decode";

const storageState = JSON.parse(sessionStorage.getItem("authData"));

const initialToken = () => {
  if (storageState?.state.accessToken) {
    return storageState.state.accessToken;
  } else {
    return "";
  }
};

const initialUserData = () => {
  if (storageState?.state.userData) {
    return storageState.state.userData;
  } else {
    return {};
  }
};

const initialIsAuthenticated = () => {
  return storageState?.state.isAuthenticated;
};

const useUserAuth = create(
  persist(
    (set) => ({
      isAuthenticated: initialIsAuthenticated(),
      accessToken: initialToken(),
      userData: initialUserData(),

      // register: async (useData) => {
      //   return await authService.register(useData);
      //   set(() => ({
      //     userData: user,
      //     accessToken: user.accessToken,
      //     isAuthenticated: true,
      //   }));
      // },

      login: async (userData) => {
        const user = await authService.login(userData);

        const decodedToken = jwtDecode(user.token);
        const userFields = Object.keys(decodedToken).reduce((acc, key) => {
          if (key.lastIndexOf("/") !== -1) {
            acc[key.substring(key.lastIndexOf("/") + 1)] = decodedToken[key];
          } else {
            acc[key] = decodedToken[key];
          }
          return acc;
        }, {});
        console.log(userFields);

        set(() => ({
          userData: userFields,
          accessToken: user.token,
          isAuthenticated: true,
        }));
      },

      logout: async () => {
        await authService.logout();

        set(() => ({
          isAuthenticated: false,
          userData: {},
          accessToken: "",
        }));
      },
    }),
    {
      name: "authData",
      storage: createJSONStorage(() => sessionStorage),
      partialize: (state) => ({
        accessToken: state.accessToken,
        isAuthenticated: state.isAuthenticated,
        // userData : {_id: state.userData._id, username:state.userData.username}
        userData: { ...state.userData },
      }),
    }
  )
);

export default useUserAuth;
