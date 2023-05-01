FROM mcr.microsoft.com/devcontainers/dotnet:0-6.0

RUN curl -sL https://deb.nodesource.com/setup_16.x -o /tmp/nodesource_setup.sh && \
bash /tmp/nodesource_setup.sh && \
apt update && \
apt install -y --no-install-recommends nodejs python pip

RUN apt update && \
apt install -y --no-install-recommends r-base r-base-dev

# Install dependencies
RUN apt update && \
apt install -y --no-install-recommends libcurl4-openssl-dev libssl-dev libxml2-dev libudunits2-dev libgdal-dev libgeos-dev libproj-dev libcairo2-dev libxt-dev libgfortran5

# Install remotes, hoopR, and tidyverse
RUN R -e "install.packages('remotes', repos='https://cloud.r-project.org/')" && \
R -e "remotes::install_github('saiemgilani/hoopR')" && \
R -e "install.packages(c('ggplot2', 'dplyr', 'tidyr', 'readr', 'purrr', 'tibble', 'stringr', 'forcats'), repos='https://cloud.r-project.org/')"
# [Optional] Uncomment this section to install additional OS packages.
# RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
#     && apt-get -y install --no-install-recommends <your-package-list-here>

# [Optional] Uncomment this line to install global node packages.
# RUN su vscode -c "source /usr/local/share/nvm/nvm.sh && npm install -g <your-package-here>" 2>&1