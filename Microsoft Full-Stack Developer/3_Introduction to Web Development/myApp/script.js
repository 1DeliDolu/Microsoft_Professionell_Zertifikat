const navToggle = document.querySelector(".nav-toggle");
const siteNav = document.querySelector(".site-nav");
const prefersReducedMotion = window.matchMedia(
  "(prefers-reduced-motion: reduce)"
).matches;

if (navToggle && siteNav) {
  navToggle.addEventListener("click", () => {
    const isOpen = siteNav.classList.toggle("is-open");
    navToggle.setAttribute("aria-expanded", String(isOpen));
  });

  siteNav.querySelectorAll("a").forEach((link) => {
    link.addEventListener("click", () => {
      siteNav.classList.remove("is-open");
      navToggle.setAttribute("aria-expanded", "false");
    });
  });
}

document.querySelectorAll('a[href^="#"]').forEach((link) => {
  link.addEventListener("click", (event) => {
    const targetId = link.getAttribute("href");
    if (!targetId || targetId === "#") {
      return;
    }

    const target = document.querySelector(targetId);
    if (target) {
      event.preventDefault();
      target.scrollIntoView({
        behavior: prefersReducedMotion ? "auto" : "smooth",
        block: "start",
      });
    }
  });
});

const filterButtons = document.querySelectorAll(".filter-button");
const projects = document.querySelectorAll(".project");

const setActiveFilter = (filter) => {
  filterButtons.forEach((button) => {
    const isActive = button.dataset.filter === filter;
    button.classList.toggle("is-active", isActive);
    button.setAttribute("aria-pressed", String(isActive));
  });

  projects.forEach((project) => {
    const category = project.dataset.category;
    const shouldShow = filter === "all" || category === filter;
    project.style.display = shouldShow ? "" : "none";
  });
};

filterButtons.forEach((button) => {
  button.setAttribute(
    "aria-pressed",
    String(button.classList.contains("is-active"))
  );
  button.addEventListener("click", () => {
    setActiveFilter(button.dataset.filter || "all");
  });
});

const lightbox = document.querySelector(".lightbox");
const lightboxImage = document.querySelector(".lightbox-image");
const lightboxCaption = document.querySelector(".lightbox-caption");
const lightboxClose = document.querySelector(".lightbox-close");
let lastFocusedElement = null;

const openLightbox = (img) => {
  if (!lightbox || !lightboxImage || !lightboxCaption) {
    return;
  }

  const captionText =
    img.closest("figure")?.querySelector("figcaption")?.textContent?.trim() ||
    img.alt ||
    "Project image";

  lastFocusedElement = document.activeElement;
  lightboxImage.src = img.src;
  lightboxImage.alt = img.alt || "Project image";
  lightboxCaption.textContent = captionText;
  lightbox.hidden = false;
  lightbox.setAttribute("aria-hidden", "false");
  document.body.style.overflow = "hidden";
  lightboxClose?.focus();
};

const closeLightbox = () => {
  if (!lightbox) {
    return;
  }
  lightbox.hidden = true;
  lightbox.setAttribute("aria-hidden", "true");
  document.body.style.overflow = "";
  if (lastFocusedElement instanceof HTMLElement) {
    lastFocusedElement.focus();
  }
};

document.querySelectorAll(".project img").forEach((img) => {
  img.addEventListener("click", () => openLightbox(img));
});

lightboxClose?.addEventListener("click", closeLightbox);

lightbox?.addEventListener("click", (event) => {
  if (event.target === lightbox) {
    closeLightbox();
  }
});

document.addEventListener("keydown", (event) => {
  if (event.key === "Escape" && lightbox && !lightbox.hidden) {
    closeLightbox();
  }
});

const contactForm = document.querySelector(".contact-form");

if (contactForm) {
  const status = contactForm.querySelector(".form-status");
  const fields = {
    "full-name": {
      input: contactForm.querySelector("#full-name"),
      error: contactForm.querySelector("#full-name-error"),
      validate: (value) =>
        value.trim().length >= 2 ? "" : "Please enter your full name.",
    },
    email: {
      input: contactForm.querySelector("#email"),
      error: contactForm.querySelector("#email-error"),
      validate: (value) =>
        /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(value.trim())
          ? ""
          : "Please enter a valid email address.",
    },
    message: {
      input: contactForm.querySelector("#message"),
      error: contactForm.querySelector("#message-error"),
      validate: (value) =>
        value.trim().length >= 10
          ? ""
          : "Message should be at least 10 characters.",
    },
  };

  const setStatus = (message, type) => {
    if (!status) {
      return;
    }
    status.textContent = message;
    status.classList.toggle("is-error", type === "error");
    status.classList.toggle("is-success", type === "success");
  };

  const validateField = (key) => {
    const field = fields[key];
    if (!field || !field.input || !field.error) {
      return true;
    }
    const message = field.validate(field.input.value);
    field.error.textContent = message;
    field.input.setAttribute("aria-invalid", message ? "true" : "false");
    return message === "";
  };

  Object.keys(fields).forEach((key) => {
    const field = fields[key];
    if (!field.input) {
      return;
    }
    field.input.addEventListener("input", () => {
      validateField(key);
    });
    field.input.addEventListener("blur", () => {
      validateField(key);
    });
  });

  contactForm.addEventListener("submit", (event) => {
    event.preventDefault();
    let allValid = true;

    Object.keys(fields).forEach((key) => {
      if (!validateField(key)) {
        allValid = false;
      }
    });

    if (!allValid) {
      setStatus("Please fix the highlighted fields.", "error");
      return;
    }

    setStatus("Thanks! Your message is ready to send.", "success");
    contactForm.reset();
    Object.keys(fields).forEach((key) => {
      const field = fields[key];
      if (field?.error) {
        field.error.textContent = "";
      }
      if (field?.input) {
        field.input.setAttribute("aria-invalid", "false");
      }
    });
  });
}
