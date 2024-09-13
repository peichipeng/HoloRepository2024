--
-- PostgreSQL database dump
--

-- Dumped from database version 16.3
-- Dumped by pg_dump version 16.3

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
-- Name: dicomfile; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.dicomfile (
    dicom_id integer NOT NULL,
    organ_id integer NOT NULL,
    dicom_path text
);


ALTER TABLE public.dicomfile OWNER TO postgres;

--
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
-- Name: dicomfile_dicom_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.dicomfile_dicom_id_seq OWNED BY public.dicomfile.dicom_id;


--
-- Name: dicomsegmentation; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.dicomsegmentation (
    dicom_segmentation_id integer NOT NULL,
    dicom_id integer NOT NULL,
    segmentation_path text
);


ALTER TABLE public.dicomsegmentation OWNER TO postgres;

--
-- Name: dicomsegmentation_dicom_segmentation_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.dicomsegmentation_dicom_segmentation_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER SEQUENCE public.dicomsegmentation_dicom_segmentation_id_seq OWNER TO postgres;

--
-- Name: dicomsegmentation_dicom_segmentation_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.dicomsegmentation_dicom_segmentation_id_seq OWNED BY public.dicomsegmentation.dicom_segmentation_id;


--
-- Name: donor; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.donor (
    donor_id integer NOT NULL,
    age integer NOT NULL,
    date_of_death date NOT NULL,
    cause_of_death text NOT NULL,
    "timestamp" timestamp with time zone DEFAULT CURRENT_TIMESTAMP NOT NULL
);


ALTER TABLE public.donor OWNER TO postgres;

--
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
-- Name: donor_donor_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.donor_donor_id_seq OWNED BY public.donor.donor_id;


--
-- Name: model3d; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.model3d (
    model_id integer NOT NULL,
    organ_id integer,
    model_path text
);


ALTER TABLE public.model3d OWNER TO postgres;

--
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
-- Name: model3d_model_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.model3d_model_id_seq OWNED BY public.model3d.model_id;


--
-- Name: organ; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.organ (
    organ_id integer NOT NULL,
    donor_id integer NOT NULL,
    organ_name_id integer,
    organ_side text
);


ALTER TABLE public.organ OWNER TO postgres;

--
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
-- Name: organ_organ_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.organ_organ_id_seq OWNED BY public.organ.organ_id;


--
-- Name: organname; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.organname (
    organ_name_id integer NOT NULL,
    organ_name text,
    has_side boolean NOT NULL
);


ALTER TABLE public.organname OWNER TO postgres;

--
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
-- Name: organname_organ_name_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.organname_organ_name_id_seq OWNED BY public.organname.organ_name_id;


--
-- Name: organtag; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.organtag (
    organ_id integer NOT NULL,
    tag_id integer NOT NULL
);


ALTER TABLE public.organtag OWNER TO postgres;

--
-- Name: segmentation; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.segmentation (
    segmentation_id integer NOT NULL,
    slice_id integer,
    segmentation_path text
);


ALTER TABLE public.segmentation OWNER TO postgres;

--
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
-- Name: segmentation_segmentation_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.segmentation_segmentation_id_seq OWNED BY public.segmentation.segmentation_id;


--
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
-- Name: sliceimage_slice_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.sliceimage_slice_id_seq OWNED BY public.sliceimage.slice_id;


--
-- Name: tag; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tag (
    tag_id integer NOT NULL,
    tag_name text NOT NULL
);


ALTER TABLE public.tag OWNER TO postgres;

--
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
-- Name: tag_tag_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tag_tag_id_seq OWNED BY public.tag.tag_id;


--
-- Name: texturemap; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.texturemap (
    texture_id integer NOT NULL,
    segmentation_id integer,
    texture_path text
);


ALTER TABLE public.texturemap OWNER TO postgres;

--
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
-- Name: texturemap_texture_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.texturemap_texture_id_seq OWNED BY public.texturemap.texture_id;


--
-- Name: dicomfile dicom_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dicomfile ALTER COLUMN dicom_id SET DEFAULT nextval('public.dicomfile_dicom_id_seq'::regclass);


--
-- Name: dicomsegmentation dicom_segmentation_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dicomsegmentation ALTER COLUMN dicom_segmentation_id SET DEFAULT nextval('public.dicomsegmentation_dicom_segmentation_id_seq'::regclass);


--
-- Name: donor donor_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.donor ALTER COLUMN donor_id SET DEFAULT nextval('public.donor_donor_id_seq'::regclass);


--
-- Name: model3d model_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.model3d ALTER COLUMN model_id SET DEFAULT nextval('public.model3d_model_id_seq'::regclass);


--
-- Name: organ organ_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organ ALTER COLUMN organ_id SET DEFAULT nextval('public.organ_organ_id_seq'::regclass);


--
-- Name: organname organ_name_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organname ALTER COLUMN organ_name_id SET DEFAULT nextval('public.organname_organ_name_id_seq'::regclass);


--
-- Name: segmentation segmentation_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.segmentation ALTER COLUMN segmentation_id SET DEFAULT nextval('public.segmentation_segmentation_id_seq'::regclass);


--
-- Name: sliceimage slice_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sliceimage ALTER COLUMN slice_id SET DEFAULT nextval('public.sliceimage_slice_id_seq'::regclass);


--
-- Name: tag tag_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tag ALTER COLUMN tag_id SET DEFAULT nextval('public.tag_tag_id_seq'::regclass);


--
-- Name: texturemap texture_id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.texturemap ALTER COLUMN texture_id SET DEFAULT nextval('public.texturemap_texture_id_seq'::regclass);


--
-- Data for Name: dicomfile; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.dicomfile (dicom_id, organ_id, dicom_path) FROM stdin;
262	11	data\\DICOMFile\\image-000001.dcm
263	11	data\\DICOMFile\\image-000002.dcm
264	11	data\\DICOMFile\\image-000003.dcm
265	11	data\\DICOMFile\\image-000004.dcm
266	11	data\\DICOMFile\\image-000005.dcm
267	11	data\\DICOMFile\\image-000006.dcm
268	11	data\\DICOMFile\\image-000007.dcm
269	11	data\\DICOMFile\\image-000008.dcm
270	11	data\\DICOMFile\\image-000009.dcm
271	11	data\\DICOMFile\\image-000010.dcm
272	12	data\\DICOMFile\\image-000001.dcm
273	12	data\\DICOMFile\\image-000002.dcm
274	12	data\\DICOMFile\\image-000003.dcm
275	12	data\\DICOMFile\\image-000004.dcm
276	12	data\\DICOMFile\\image-000005.dcm
277	12	data\\DICOMFile\\image-000006.dcm
278	12	data\\DICOMFile\\image-000007.dcm
279	12	data\\DICOMFile\\image-000008.dcm
280	12	data\\DICOMFile\\image-000009.dcm
281	12	data\\DICOMFile\\image-000010.dcm
292	13	data\\DICOMFile\\image-000001.dcm
293	13	data\\DICOMFile\\image-000002.dcm
294	13	data\\DICOMFile\\image-000003.dcm
295	13	data\\DICOMFile\\image-000004.dcm
296	13	data\\DICOMFile\\image-000005.dcm
297	13	data\\DICOMFile\\image-000006.dcm
298	13	data\\DICOMFile\\image-000007.dcm
299	13	data\\DICOMFile\\image-000008.dcm
300	13	data\\DICOMFile\\image-000009.dcm
301	13	data\\DICOMFile\\image-000010.dcm
\.


--
-- Data for Name: dicomsegmentation; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.dicomsegmentation (dicom_segmentation_id, dicom_id, segmentation_path) FROM stdin;
\.


--
-- Data for Name: donor; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.donor (donor_id, age, date_of_death, cause_of_death, "timestamp") FROM stdin;
2	68	2023-09-15	cancer	2024-09-12 09:17:19.43752+01
1	78	2022-09-13	natural death	2024-09-12 09:18:15.193584+01
3	67	2024-05-08	traffic accident	2024-09-12 09:23:17.887987+01
\.


--
-- Data for Name: model3d; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.model3d (model_id, organ_id, model_path) FROM stdin;
7	12	\N
9	13	data\\Model3D\\kidney_test_0000.glb
\.


--
-- Data for Name: organ; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.organ (organ_id, donor_id, organ_name_id, organ_side) FROM stdin;
11	1	1	\N
12	2	5	\N
13	3	3	Left
\.


--
-- Data for Name: organname; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.organname (organ_name_id, organ_name, has_side) FROM stdin;
1	Heart	f
2	Lung	t
3	Kidney	t
4	Liver	f
5	Brain	f
6	Stomach	f
\.


--
-- Data for Name: organtag; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.organtag (organ_id, tag_id) FROM stdin;
11	5
12	7
13	8
\.


--
-- Data for Name: segmentation; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.segmentation (segmentation_id, slice_id, segmentation_path) FROM stdin;
\.


--
-- Data for Name: sliceimage; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.sliceimage (slice_id, organ_id, dicom_id, additional_info, image_path) FROM stdin;
14	11	262	demo	data\\SliceImage\\1-Heart-0001-20240912.jpg
15	12	278	demonstration	data\\SliceImage\\2-Brain-0001-20240912.jpg
17	13	299	demo	data\\SliceImage\\3-Kidney(Left)-0001-20240912.jpg
\.


--
-- Data for Name: tag; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tag (tag_id, tag_name) FROM stdin;
1	COVID-19
2	Diabetes
3	Obesity
4	Malnutrition
5	Healthy
6	Alcoholism
7	Cancer
8	Traffic Accident
\.


--
-- Data for Name: texturemap; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.texturemap (texture_id, segmentation_id, texture_path) FROM stdin;
\.


--
-- Name: dicomfile_dicom_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.dicomfile_dicom_id_seq', 301, true);


--
-- Name: dicomsegmentation_dicom_segmentation_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.dicomsegmentation_dicom_segmentation_id_seq', 1, false);


--
-- Name: donor_donor_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.donor_donor_id_seq', 1, true);


--
-- Name: model3d_model_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.model3d_model_id_seq', 9, true);


--
-- Name: organ_organ_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.organ_organ_id_seq', 13, true);


--
-- Name: organname_organ_name_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.organname_organ_name_id_seq', 6, true);


--
-- Name: segmentation_segmentation_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.segmentation_segmentation_id_seq', 1, false);


--
-- Name: sliceimage_slice_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.sliceimage_slice_id_seq', 17, true);


--
-- Name: tag_tag_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tag_tag_id_seq', 8, true);


--
-- Name: texturemap_texture_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.texturemap_texture_id_seq', 1, false);


--
-- Name: dicomfile dicomfile_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dicomfile
    ADD CONSTRAINT dicomfile_pkey PRIMARY KEY (dicom_id);


--
-- Name: dicomsegmentation dicomsegmentation_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dicomsegmentation
    ADD CONSTRAINT dicomsegmentation_pkey PRIMARY KEY (dicom_segmentation_id);


--
-- Name: donor donor_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.donor
    ADD CONSTRAINT donor_pkey PRIMARY KEY (donor_id);


--
-- Name: model3d model3d_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.model3d
    ADD CONSTRAINT model3d_pkey PRIMARY KEY (model_id);


--
-- Name: organ organ_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organ
    ADD CONSTRAINT organ_pkey PRIMARY KEY (organ_id);


--
-- Name: organname organname_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organname
    ADD CONSTRAINT organname_pkey PRIMARY KEY (organ_name_id);


--
-- Name: organtag organtag_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT organtag_pkey PRIMARY KEY (organ_id, tag_id);


--
-- Name: segmentation segmentation_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.segmentation
    ADD CONSTRAINT segmentation_pkey PRIMARY KEY (segmentation_id);


--
-- Name: sliceimage sliceimage_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT sliceimage_pkey PRIMARY KEY (slice_id);


--
-- Name: tag tag_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tag
    ADD CONSTRAINT tag_pkey PRIMARY KEY (tag_id);


--
-- Name: texturemap texturemap_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.texturemap
    ADD CONSTRAINT texturemap_pkey PRIMARY KEY (texture_id);


--
-- Name: sliceimage dicom_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT dicom_id FOREIGN KEY (dicom_id) REFERENCES public.dicomfile(dicom_id) ON DELETE CASCADE;


--
-- Name: dicomsegmentation dicom_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dicomsegmentation
    ADD CONSTRAINT dicom_id FOREIGN KEY (dicom_id) REFERENCES public.dicomfile(dicom_id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: organ donor_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organ
    ADD CONSTRAINT donor_id FOREIGN KEY (donor_id) REFERENCES public.donor(donor_id) ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: organtag organ_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;


--
-- Name: model3d organ_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.model3d
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;


--
-- Name: sliceimage organ_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.sliceimage
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;


--
-- Name: dicomfile organ_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.dicomfile
    ADD CONSTRAINT organ_id FOREIGN KEY (organ_id) REFERENCES public.organ(organ_id) ON DELETE CASCADE;


--
-- Name: organ organ_name_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organ
    ADD CONSTRAINT organ_name_id FOREIGN KEY (organ_name_id) REFERENCES public.organname(organ_name_id);


--
-- Name: texturemap segmentation_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.texturemap
    ADD CONSTRAINT segmentation_id FOREIGN KEY (segmentation_id) REFERENCES public.segmentation(segmentation_id) ON DELETE CASCADE;


--
-- Name: segmentation slice_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.segmentation
    ADD CONSTRAINT slice_id FOREIGN KEY (slice_id) REFERENCES public.sliceimage(slice_id) ON DELETE CASCADE;


--
-- Name: organtag tag_id; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.organtag
    ADD CONSTRAINT tag_id FOREIGN KEY (tag_id) REFERENCES public.tag(tag_id) ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

