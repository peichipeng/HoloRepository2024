--
-- PostgreSQL database dump
--

-- Dumped from database version 16.3
-- Dumped by pg_dump version 16.3

-- Started on 2024-07-17 12:09:36

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 215 (class 1259 OID 16400)
-- Name: dicomfile; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.dicomfile (
    dicom_id integer NOT NULL,
    organ_id integer NOT NULL,
    dicom_path text
);


ALTER TABLE public.dicomfile OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 16405)
-- Name: dicomfile_dicom_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.dicomfile_dicom_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.dicomfile_dicom_id_seq OWNER TO postgres;

--
-- TOC entry 4884 (class 0 OID 0)
-- Dependencies: 216
-- Name: dicomfile_dicom_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.dicomfile_dicom_id_seq OWNED BY public.dicomfile.dicom_id;


--
-- TOC entry 217 (class 1259 OID 16406)
-- Name: donor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.donor (
    donor_id integer NOT NULL,
    age integer NOT NULL,
    date_of_death date NOT NULL,
    cause_of_death text NOT NULL
);


ALTER TABLE public.donor OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 16411)
-- Name: donor_donor_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.donor_donor_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.donor_donor_id_seq OWNER TO postgres;

--
-- TOC entry 4885 (class 0 OID 0)
-- Dependencies: 218
-- Name: donor_donor_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.donor_donor_id_seq OWNED BY public.donor.donor_id;


--
-- TOC entry 219 (class 1259 OID 16412)
-- Name: model3d; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.model3d (
    model_id integer NOT NULL,
    organ_id integer,
    model_path text
);


ALTER TABLE public.model3d OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 16417)
-- Name: model3d_model_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.model3d_model_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.model3d_model_id_seq OWNER TO postgres;

--
-- TOC entry 4886 (class 0 OID 0)
-- Dependencies: 220
-- Name: model3d_model_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.model3d_model_id_seq OWNED BY public.model3d.model_id;


--
-- TOC entry 221 (class 1259 OID 16418)
-- Name: organ; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.organ (
    organ_id integer NOT NULL,
    donor_id integer NOT NULL,
    organ_name_id integer
);


ALTER TABLE public.organ OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 16421)
-- Name: organ_organ_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.organ_organ_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.organ_organ_id_seq OWNER TO postgres;

--
-- TOC entry 4887 (class 0 OID 0)
-- Dependencies: 222
-- Name: organ_organ_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.organ_organ_id_seq OWNED BY public.organ.organ_id;


--
-- TOC entry 223 (class 1259 OID 16422)
-- Name: organname; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.organname (
    organ_name_id integer NOT NULL,
    organ_name text
);


ALTER TABLE public.organname OWNER TO postgres;

--
-- TOC entry 224 (class 1259 OID 16427)
-- Name: organname_organ_name_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.organname_organ_name_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.organname_organ_name_id_seq OWNER TO postgres;

--
-- TOC entry 4888 (class 0 OID 0)
-- Dependencies: 224
-- Name: organname_organ_name_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.organname_organ_name_id_seq OWNED BY public.organname.organ_name_id;


--
-- TOC entry 225 (class 1259 OID 16428)
-- Name: organtag; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.organtag (
    organ_id integer NOT NULL,
    tag_id integer NOT NULL
);


ALTER TABLE public.organtag OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 16431)
-- Name: segmentation; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.segmentation (
    segmentation_id integer NOT NULL,
    slice_id integer,
    segmentation_path text
);


ALTER TABLE public.segmentation OWNER TO postgres;

--
-- TOC entry 227 (class 1259 OID 16436)
-- Name: segmentation_segmentation_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.segmentation_segmentation_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.segmentation_segmentation_id_seq OWNER TO postgres;

--
-- TOC entry 4889 (class 0 OID 0)
-- Dependencies: 227
-- Name: segmentation_segmentation_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.segmentation_segmentation_id_seq OWNED BY public.segmentation.segmentation_id;


--
-- TOC entry 228 (class 1259 OID 16437)
-- Name: sliceimage; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.sliceimage (
    slice_id integer NOT NULL,
    organ_id integer,
    dicom_id integer,
    additional_info text,
    image_path text
);


ALTER TABLE public.sliceimage OWNER TO postgres;

--
-- TOC entry 229 (class 1259 OID 16442)
-- Name: sliceimage_slice_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.sliceimage_slice_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.sliceimage_slice_id_seq OWNER TO postgres;

--
-- TOC entry 4890 (class 0 OID 0)
-- Dependencies: 229
-- Name: sliceimage_slice_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.sliceimage_slice_id_seq OWNED BY public.sliceimage.slice_id;


--
-- TOC entry 230 (class 1259 OID 16443)
-- Name: tag; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tag (
    tag_id integer NOT NULL,
    tag_name text NOT NULL
);


ALTER TABLE public.tag OWNER TO postgres;

--
-- TOC entry 231 (class 1259 OID 16448)
-- Name: tag_tag_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tag_tag_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.tag_tag_id_seq OWNER TO postgres;

--
-- TOC entry 4891 (class 0 OID 0)
-- Dependencies: 231
-- Name: tag_tag_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tag_tag_id_seq OWNED BY public.tag.tag_id;


--
-- TOC entry 232 (class 1259 OID 16449)
-- Name: texturemap; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.texturemap (
    texture_id integer NOT NULL,
    segmentation_id integer,
    texture_path text
);


ALTER TABLE public.texturemap OWNER TO postgres;

--
-- TOC entry 233 (class 1259 OID 16454)
-- Name: texturemap_texture_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.texturemap_texture_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.texturemap_texture_id_seq OWNER TO postgres;

--
-- TOC entry 4892 (class 0 OID 0)
-- Dependencies: 233
-- Name: texturemap_texture_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.texturemap_texture_id_seq OWNED BY public.texturemap.texture_id;


--
-- TOC entry 4678 (class 2604 OID 16455)
-- Name: dicomfile dicom_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dicomfile ALTER COLUMN dicom_id SET DEFAULT nextval('public.dicomfile_dicom_id_seq'::regclass);


--
-- TOC entry 4679 (class 2604 OID 16456)
-- Name: donor donor_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.donor ALTER COLUMN donor_id SET DEFAULT nextval('public.donor_donor_id_seq'::regclass);


--
-- TOC entry 4680 (class 2604 OID 16457)
-- Name: model3d model_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.model3d ALTER COLUMN model_id SET DEFAULT nextval('public.model3d_model_id_seq'::regclass);


--
-- TOC entry 4681 (class 2604 OID 16458)
-- Name: organ organ_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organ ALTER COLUMN organ_id SET DEFAULT nextval('public.organ_organ_id_seq'::regclass);


--
-- TOC entry 4682 (class 2604 OID 16459)
-- Name: organname organ_name_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organname ALTER COLUMN organ_name_id SET DEFAULT nextval('public.organname_organ_name_id_seq'::regclass);


--
-- TOC entry 4683 (class 2604 OID 16460)
-- Name: segmentation segmentation_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.segmentation ALTER COLUMN segmentation_id SET DEFAULT nextval('public.segmentation_segmentation_id_seq'::regclass);


--
-- TOC entry 4684 (class 2604 OID 16461)
-- Name: sliceimage slice_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sliceimage ALTER COLUMN slice_id SET DEFAULT nextval('public.sliceimage_slice_id_seq'::regclass);


--
-- TOC entry 4685 (class 2604 OID 16462)
-- Name: tag tag_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tag ALTER COLUMN tag_id SET DEFAULT nextval('public.tag_tag_id_seq'::regclass);


--
-- TOC entry 4686 (class 2604 OID 16463)
-- Name: texturemap texture_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.texturemap ALTER COLUMN texture_id SET DEFAULT nextval('public.texturemap_texture_id_seq'::regclass);


--
-- TOC entry 4860 (class 0 OID 16400)
-- Dependencies: 215
-- Data for Name: dicomfile; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.dicomfile (dicom_id, organ_id, dicom_path) FROM stdin;
\.


--
-- TOC entry 4862 (class 0 OID 16406)
-- Dependencies: 217
-- Data for Name: donor; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.donor (donor_id, age, date_of_death, cause_of_death) FROM stdin;
3	44	2022-06-28	cancer
5	44	2028-07-26	cancer
6	60	2006-06-24	cancer
7	44	2023-03-26	cancer
4	33	2001-03-26	cancer
8	33	2023-08-26	cancer
10	33	2023-04-26	cancer
11	33	2023-04-26	cancer
13	44	2001-04-26	cancer
12	33	2023-04-26	cancer
14	40	2001-05-26	cancer
34	40	2001-05-26	cancer
1	33	2001-06-06	cancer
30	33	2001-04-26	cancer
29	34	2001-03-24	cancer
123	33	2023-04-26	cancer
332	44	2001-07-26	cancer
1234	33	2001-04-25	cancer
100	34	2023-06-26	cancer
101	44	2023-04-26	cancer
21	70	2024-10-08	cancer
2001	50	2001-06-30	cancer
5000	66	2001-05-30	cancer
555	33	2001-06-26	cancer
1011	33	2001-04-26	cancer
2000	33	2000-04-26	cancer
\.


--
-- TOC entry 4864 (class 0 OID 16412)
-- Dependencies: 219
-- Data for Name: model3d; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.model3d (model_id, organ_id, model_path) FROM stdin;
\.


--
-- TOC entry 4866 (class 0 OID 16418)
-- Dependencies: 221
-- Data for Name: organ; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.organ (organ_id, donor_id, organ_name_id) FROM stdin;
1	21	3
2	21	4
\.


--
-- TOC entry 4868 (class 0 OID 16422)
-- Dependencies: 223
-- Data for Name: organname; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.organname (organ_name_id, organ_name) FROM stdin;
1	Heart
2	Lung
3	Kidney
4	Liver
5	Brain
6	Stomach
\.


--
-- TOC entry 4870 (class 0 OID 16428)
-- Dependencies: 225
-- Data for Name: organtag; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.organtag (organ_id, tag_id) FROM stdin;
1	1
1	2
\.


--
-- TOC entry 4871 (class 0 OID 16431)
-- Dependencies: 226
-- Data for Name: segmentation; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.segmentation (segmentation_id, slice_id, segmentation_path) FROM stdin;
\.


--
-- TOC entry 4873 (class 0 OID 16437)
-- Dependencies: 228
-- Data for Name: sliceimage; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.sliceimage (slice_id, organ_id, dicom_id, additional_info, image_path) FROM stdin;
1	1	\N	\N	C:\\HoloRepository\\SliceImage\\slice_id_1.png
2	1	\N	\N	C:\\HoloRepository\\SliceImage\\slice_id_2.png
3	1	\N	\N	C:\\HoloRepository\\SliceImage\\slice_id_3.png
\.


--
-- TOC entry 4875 (class 0 OID 16443)
-- Dependencies: 230
-- Data for Name: tag; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tag (tag_id, tag_name) FROM stdin;
1	COVID-19
2	Diabetes
3	Obesity
4	Malnutrition
5	Healthy
6	Alcoholism
\.


--
-- TOC entry 4877 (class 0 OID 16449)
-- Dependencies: 232
-- Data for Name: texturemap; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.texturemap (texture_id, segmentation_id, texture_path) FROM stdin;
\.


--
-- TOC entry 4893 (class 0 OID 0)
-- Dependencies: 216
-- Name: dicomfile_dicom_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.dicomfile_dicom_id_seq', 1, false);


--
-- TOC entry 4894 (class 0 OID 0)
-- Dependencies: 218
-- Name: donor_donor_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.donor_donor_id_seq', 1, true);


--
-- TOC entry 4895 (class 0 OID 0)
-- Dependencies: 220
-- Name: model3d_model_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.model3d_model_id_seq', 1, false);


--
-- TOC entry 4896 (class 0 OID 0)
-- Dependencies: 222
-- Name: organ_organ_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.organ_organ_id_seq', 1, true);


--
-- TOC entry 4897 (class 0 OID 0)
-- Dependencies: 224
-- Name: organname_organ_name_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.organname_organ_name_id_seq', 6, true);


--
-- TOC entry 4898 (class 0 OID 0)
-- Dependencies: 227
-- Name: segmentation_segmentation_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.segmentation_segmentation_id_seq', 1, false);


--
-- TOC entry 4899 (class 0 OID 0)
-- Dependencies: 229
-- Name: sliceimage_slice_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.sliceimage_slice_id_seq', 1, false);


--
-- TOC entry 4900 (class 0 OID 0)
-- Dependencies: 231
-- Name: tag_tag_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tag_tag_id_seq', 6, true);


--
-- TOC entry 4901 (class 0 OID 0)
-- Dependencies: 233
-- Name: texturemap_texture_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.texturemap_texture_id_seq', 1, false);


--
-- TOC entry 4688 (class 2606 OID 16465)
-- Name: dicomfile dicomfile_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dicomfile
    ADD CONSTRAINT dicomfile_pkey PRIMARY KEY (dicom_id);


--
-- TOC entry 4690 (class 2606 OID 16467)
-- Name: donor donor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.donor
    ADD CONSTRAINT donor_pkey PRIMARY KEY (donor_id);


--
-- TOC entry 4692 (class 2606 OID 16469)
-- Name: model3d model3d_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.model3d
    ADD CONSTRAINT model3d_pkey PRIMARY KEY (model_id);


--
-- TOC entry 4694 (class 2606 OID 16471)
-- Name: organ organ_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organ
    ADD CONSTRAINT organ_pkey PRIMARY KEY (organ_id);


--
-- TOC entry 4696 (class 2606 OID 16473)
-- Name: organname organname_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organname
    ADD CONSTRAINT organname_pkey PRIMARY KEY (organ_name_id);


--
-- TOC entry 4698 (class 2606 OID 16475)
-- Name: organtag organtag_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT organtag_pkey PRIMARY KEY (organ_id, tag_id);


--
-- TOC entry 4700 (class 2606 OID 16477)
-- Name: segmentation segmentation_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.segmentation
    ADD CONSTRAINT segmentation_pkey PRIMARY KEY (segmentation_id);


--
-- TOC entry 4702 (class 2606 OID 16479)
-- Name: sliceimage sliceimage_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT sliceimage_pkey PRIMARY KEY (slice_id);


--
-- TOC entry 4704 (class 2606 OID 16481)
-- Name: tag tag_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tag
    ADD CONSTRAINT tag_pkey PRIMARY KEY (tag_id);


--
-- TOC entry 4706 (class 2606 OID 16483)
-- Name: texturemap texturemap_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.texturemap
    ADD CONSTRAINT texturemap_pkey PRIMARY KEY (texture_id);


--
-- TOC entry 4714 (class 2606 OID 16484)
-- Name: sliceimage dicom_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT dicom_id FOREIGN KEY (dicom_id) REFERENCES public.dicomfile(dicom_id) ON DELETE CASCADE;


--
-- TOC entry 4709 (class 2606 OID 16562)
-- Name: organ donor_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organ
    ADD CONSTRAINT donor_id FOREIGN KEY (donor_id) REFERENCES public.donor(donor_id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- TOC entry 4711 (class 2606 OID 16494)
-- Name: organtag organ_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;


--
-- TOC entry 4708 (class 2606 OID 16499)
-- Name: model3d organ_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.model3d
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;


--
-- TOC entry 4715 (class 2606 OID 16504)
-- Name: sliceimage organ_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;


--
-- TOC entry 4707 (class 2606 OID 16509)
-- Name: dicomfile organ_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dicomfile
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;


--
-- TOC entry 4710 (class 2606 OID 16514)
-- Name: organ organ_name_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organ
    ADD CONSTRAINT organ_name_id FOREIGN KEY (organ_name_id) REFERENCES public.organname(organ_name_id);


--
-- TOC entry 4716 (class 2606 OID 16519)
-- Name: texturemap segmentation_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.texturemap
    ADD CONSTRAINT segmentation_id FOREIGN KEY (segmentation_id) REFERENCES public.segmentation(segmentation_id) ON DELETE CASCADE;


--
-- TOC entry 4713 (class 2606 OID 16524)
-- Name: segmentation slice_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.segmentation
    ADD CONSTRAINT slice_id FOREIGN KEY (slice_id) REFERENCES public.sliceimage(slice_id) ON DELETE CASCADE;


--
-- TOC entry 4712 (class 2606 OID 16529)
-- Name: organtag tag_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT tag_id FOREIGN KEY (tag_id) REFERENCES public.tag(tag_id) ON DELETE CASCADE;


-- Completed on 2024-07-17 12:09:37

--
-- PostgreSQL database dump complete
--

