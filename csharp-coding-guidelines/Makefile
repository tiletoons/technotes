include ~/.mk/config.mk
include ~/.mk/msbuild.mk

# msbuild configuration
APP_NAME = Thermota
APP_SRCDIR = ${SRCDIR}/code/${APP_NAME}
APP_OUTDIR = ${OUTDIR}/${APP_NAME}

.DEFAULT_GOAL = all

.PHONY: all build build-hmtl build-pdf

all: clean build ## Run all targets (default)

build: build-html build-pdf build-app ## Build document in all formats as well as example application

build-html: init ## Build document in HTML format
	@$(foreach file, $(wildcard ${SRCDIR}/*.adoc), asciidoctor \
		-r asciidoctor-diagram -D ${OUTDIR}/html $(file);)

build-pdf: init ## Build document in PDF format
	@$(foreach file, $(wildcard ${SRCDIR}/*.adoc), asciidoctor-pdf \
		-r asciidoctor-diagram -D ${OUTDIR}/pdf $(file);)
